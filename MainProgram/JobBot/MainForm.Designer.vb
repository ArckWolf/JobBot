<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.cmsMenyy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.lbMinimizeLogin = New System.Windows.Forms.Label()
        Me.lbExitLogin = New System.Windows.Forms.Label()
        Me.lbOfflineTime = New System.Windows.Forms.Label()
        Me.pbLogin = New System.Windows.Forms.PictureBox()
        Me.lbLoginError = New System.Windows.Forms.Label()
        Me.lbMail = New System.Windows.Forms.Label()
        Me.tbUserPassword = New System.Windows.Forms.TextBox()
        Me.tbUserId = New System.Windows.Forms.TextBox()
        Me.pbLoginBackground = New System.Windows.Forms.PictureBox()
        Me.timeCheckIn = New System.Windows.Forms.Timer(Me.components)
        Me.bwLogin = New System.ComponentModel.BackgroundWorker()
        Me.bwScan = New System.ComponentModel.BackgroundWorker()
        Me.timeOnline = New System.Windows.Forms.Timer(Me.components)
        Me.timeOffline = New System.Windows.Forms.Timer(Me.components)
        Me.wbBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.wbBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BrauserPanel = New System.Windows.Forms.Panel()
        Me.pbConnectBackground = New System.Windows.Forms.PictureBox()
        Me.pbConnectGif = New System.Windows.Forms.PictureBox()
        Me.ConnectPanel = New System.Windows.Forms.Panel()
        Me.pbMainBackground = New System.Windows.Forms.PictureBox()
        Me.pbGIF = New System.Windows.Forms.PictureBox()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        Me.cbMedia = New System.Windows.Forms.CheckBox()
        Me.cbInRunning = New System.Windows.Forms.CheckBox()
        Me.cbResource = New System.Windows.Forms.CheckBox()
        Me.cbQC = New System.Windows.Forms.CheckBox()
        Me.cbUATTesting = New System.Windows.Forms.CheckBox()
        Me.cbBroadcasting = New System.Windows.Forms.CheckBox()
        Me.lbTaskType = New System.Windows.Forms.Label()
        Me.lbEndTime = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lbRegisterd = New System.Windows.Forms.Label()
        Me.lbStartTime = New System.Windows.Forms.Label()
        Me.lbCounter = New System.Windows.Forms.Label()
        Me.pbStartStop = New System.Windows.Forms.PictureBox()
        Me.pbCalendar = New System.Windows.Forms.PictureBox()
        Me.lbTaskType2 = New System.Windows.Forms.Label()
        Me.lbMainError = New System.Windows.Forms.Label()
        Me.lbOfflineTimeMain = New System.Windows.Forms.Label()
        Me.lbOnlineTimeMain = New System.Windows.Forms.Label()
        Me.lbExit = New System.Windows.Forms.Label()
        Me.lbMinimize = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.pbCalendarBackground = New System.Windows.Forms.PictureBox()
        Me.clbTimes = New System.Windows.Forms.CheckedListBox()
        Me.lbDateStartTime = New System.Windows.Forms.Label()
        Me.lbDateEndTime = New System.Windows.Forms.Label()
        Me.dtpStartDateTime = New System.Windows.Forms.DateTimePicker()
        Me.lbStartD = New System.Windows.Forms.Label()
        Me.lbStartT = New System.Windows.Forms.Label()
        Me.dtpEndDateTime = New System.Windows.Forms.DateTimePicker()
        Me.lbEndD = New System.Windows.Forms.Label()
        Me.lbEndT = New System.Windows.Forms.Label()
        Me.lbStartDT = New System.Windows.Forms.Label()
        Me.lbEndDT = New System.Windows.Forms.Label()
        Me.pbAddTime = New System.Windows.Forms.PictureBox()
        Me.pbRemoveTime = New System.Windows.Forms.PictureBox()
        Me.pbFinish = New System.Windows.Forms.PictureBox()
        Me.lbCalendarError = New System.Windows.Forms.Label()
        Me.lbOfflineTimeCalendar = New System.Windows.Forms.Label()
        Me.lbOnlineTimeCalendar = New System.Windows.Forms.Label()
        Me.lbExitCalendar = New System.Windows.Forms.Label()
        Me.lbMinimizeCalendar = New System.Windows.Forms.Label()
        Me.CalendarPanel = New System.Windows.Forms.Panel()
        Me.pbWidgetBackground = New System.Windows.Forms.PictureBox()
        Me.pbSearchSmallGIF = New System.Windows.Forms.PictureBox()
        Me.lbWidgetRefreshCounter = New System.Windows.Forms.Label()
        Me.lbWidgetTaskCounter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbExitWidget = New System.Windows.Forms.Label()
        Me.lbMaximizeWidget = New System.Windows.Forms.Label()
        Me.WidgetPanel = New System.Windows.Forms.Panel()
        Me.cmsMenyy.SuspendLayout()
        Me.LoginPanel.SuspendLayout()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoginBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BrauserPanel.SuspendLayout()
        CType(Me.pbConnectBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConnectGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConnectPanel.SuspendLayout()
        CType(Me.pbMainBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStartStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.pbCalendarBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRemoveTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFinish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CalendarPanel.SuspendLayout()
        CType(Me.pbWidgetBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSearchSmallGIF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WidgetPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsMenyy
        '
        Me.cmsMenyy.BackColor = System.Drawing.Color.DimGray
        Me.cmsMenyy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmsMenyy.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmsMenyy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.MinimizeToolStripMenuItem, Me.MaximizeToolStripMenuItem})
        Me.cmsMenyy.Name = "cmsMenyy"
        Me.cmsMenyy.ShowImageMargin = False
        Me.cmsMenyy.Size = New System.Drawing.Size(107, 70)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'LoginPanel
        '
        Me.LoginPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LoginPanel.Controls.Add(Me.lbMinimizeLogin)
        Me.LoginPanel.Controls.Add(Me.lbExitLogin)
        Me.LoginPanel.Controls.Add(Me.lbOfflineTime)
        Me.LoginPanel.Controls.Add(Me.pbLogin)
        Me.LoginPanel.Controls.Add(Me.lbLoginError)
        Me.LoginPanel.Controls.Add(Me.lbMail)
        Me.LoginPanel.Controls.Add(Me.tbUserPassword)
        Me.LoginPanel.Controls.Add(Me.tbUserId)
        Me.LoginPanel.Controls.Add(Me.pbLoginBackground)
        Me.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(1513, 830)
        Me.LoginPanel.TabIndex = 60
        '
        'lbMinimizeLogin
        '
        Me.lbMinimizeLogin.AutoSize = True
        Me.lbMinimizeLogin.BackColor = System.Drawing.Color.Gray
        Me.lbMinimizeLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbMinimizeLogin.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbMinimizeLogin.ForeColor = System.Drawing.Color.White
        Me.lbMinimizeLogin.Location = New System.Drawing.Point(837, 169)
        Me.lbMinimizeLogin.Name = "lbMinimizeLogin"
        Me.lbMinimizeLogin.Size = New System.Drawing.Size(68, 19)
        Me.lbMinimizeLogin.TabIndex = 74
        Me.lbMinimizeLogin.Text = "Minimize"
        '
        'lbExitLogin
        '
        Me.lbExitLogin.AutoSize = True
        Me.lbExitLogin.BackColor = System.Drawing.Color.Gray
        Me.lbExitLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbExitLogin.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbExitLogin.ForeColor = System.Drawing.Color.White
        Me.lbExitLogin.Location = New System.Drawing.Point(911, 169)
        Me.lbExitLogin.Name = "lbExitLogin"
        Me.lbExitLogin.Size = New System.Drawing.Size(32, 19)
        Me.lbExitLogin.TabIndex = 73
        Me.lbExitLogin.Text = "Exit"
        '
        'lbOfflineTime
        '
        Me.lbOfflineTime.AutoSize = True
        Me.lbOfflineTime.BackColor = System.Drawing.Color.DimGray
        Me.lbOfflineTime.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbOfflineTime.ForeColor = System.Drawing.Color.DarkRed
        Me.lbOfflineTime.Location = New System.Drawing.Point(533, 258)
        Me.lbOfflineTime.Name = "lbOfflineTime"
        Me.lbOfflineTime.Size = New System.Drawing.Size(23, 32)
        Me.lbOfflineTime.TabIndex = 61
        Me.lbOfflineTime.Text = " "
        '
        'pbLogin
        '
        Me.pbLogin.BackColor = System.Drawing.Color.YellowGreen
        Me.pbLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLogin.Image = Global.JobBot.My.Resources.Resources.Login
        Me.pbLogin.Location = New System.Drawing.Point(645, 447)
        Me.pbLogin.Name = "pbLogin"
        Me.pbLogin.Size = New System.Drawing.Size(174, 59)
        Me.pbLogin.TabIndex = 60
        Me.pbLogin.TabStop = False
        '
        'lbLoginError
        '
        Me.lbLoginError.BackColor = System.Drawing.Color.Gray
        Me.lbLoginError.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbLoginError.ForeColor = System.Drawing.Color.DarkRed
        Me.lbLoginError.Location = New System.Drawing.Point(523, 509)
        Me.lbLoginError.Name = "lbLoginError"
        Me.lbLoginError.Size = New System.Drawing.Size(420, 65)
        Me.lbLoginError.TabIndex = 58
        Me.lbLoginError.Text = "ERROR"
        Me.lbLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbLoginError.Visible = False
        '
        'lbMail
        '
        Me.lbMail.AutoSize = True
        Me.lbMail.BackColor = System.Drawing.Color.Gray
        Me.lbMail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbMail.ForeColor = System.Drawing.Color.White
        Me.lbMail.Location = New System.Drawing.Point(694, 315)
        Me.lbMail.Name = "lbMail"
        Me.lbMail.Size = New System.Drawing.Size(215, 21)
        Me.lbMail.TabIndex = 57
        Me.lbMail.Text = "@sportsdataservices.co.uk"
        '
        'tbUserPassword
        '
        Me.tbUserPassword.BackColor = System.Drawing.Color.DimGray
        Me.tbUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUserPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.tbUserPassword.ForeColor = System.Drawing.SystemColors.Info
        Me.tbUserPassword.Location = New System.Drawing.Point(539, 383)
        Me.tbUserPassword.Name = "tbUserPassword"
        Me.tbUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbUserPassword.Size = New System.Drawing.Size(384, 20)
        Me.tbUserPassword.TabIndex = 56
        '
        'tbUserId
        '
        Me.tbUserId.BackColor = System.Drawing.Color.DimGray
        Me.tbUserId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUserId.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.tbUserId.ForeColor = System.Drawing.SystemColors.Info
        Me.tbUserId.Location = New System.Drawing.Point(539, 316)
        Me.tbUserId.Name = "tbUserId"
        Me.tbUserId.Size = New System.Drawing.Size(158, 20)
        Me.tbUserId.TabIndex = 55
        '
        'pbLoginBackground
        '
        Me.pbLoginBackground.ContextMenuStrip = Me.cmsMenyy
        Me.pbLoginBackground.Image = Global.JobBot.My.Resources.Resources.LoginBackground
        Me.pbLoginBackground.Location = New System.Drawing.Point(425, 0)
        Me.pbLoginBackground.Name = "pbLoginBackground"
        Me.pbLoginBackground.Size = New System.Drawing.Size(615, 790)
        Me.pbLoginBackground.TabIndex = 0
        Me.pbLoginBackground.TabStop = False
        '
        'timeCheckIn
        '
        Me.timeCheckIn.Interval = 1000
        '
        'bwLogin
        '
        Me.bwLogin.WorkerReportsProgress = True
        Me.bwLogin.WorkerSupportsCancellation = True
        '
        'bwScan
        '
        Me.bwScan.WorkerReportsProgress = True
        Me.bwScan.WorkerSupportsCancellation = True
        '
        'timeOnline
        '
        Me.timeOnline.Interval = 1000
        '
        'timeOffline
        '
        Me.timeOffline.Interval = 1000
        '
        'wbBrowser2
        '
        Me.wbBrowser2.Location = New System.Drawing.Point(781, 24)
        Me.wbBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbBrowser2.Name = "wbBrowser2"
        Me.wbBrowser2.ScriptErrorsSuppressed = True
        Me.wbBrowser2.Size = New System.Drawing.Size(681, 741)
        Me.wbBrowser2.TabIndex = 1
        '
        'wbBrowser1
        '
        Me.wbBrowser1.Location = New System.Drawing.Point(62, 24)
        Me.wbBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbBrowser1.Name = "wbBrowser1"
        Me.wbBrowser1.ScriptErrorsSuppressed = True
        Me.wbBrowser1.Size = New System.Drawing.Size(678, 741)
        Me.wbBrowser1.TabIndex = 0
        '
        'BrauserPanel
        '
        Me.BrauserPanel.Controls.Add(Me.wbBrowser1)
        Me.BrauserPanel.Controls.Add(Me.wbBrowser2)
        Me.BrauserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrauserPanel.Location = New System.Drawing.Point(0, 0)
        Me.BrauserPanel.Name = "BrauserPanel"
        Me.BrauserPanel.Size = New System.Drawing.Size(1513, 830)
        Me.BrauserPanel.TabIndex = 60
        Me.BrauserPanel.Visible = False
        '
        'pbConnectBackground
        '
        Me.pbConnectBackground.ContextMenuStrip = Me.cmsMenyy
        Me.pbConnectBackground.Image = Global.JobBot.My.Resources.Resources.ConnectBackground
        Me.pbConnectBackground.Location = New System.Drawing.Point(418, 0)
        Me.pbConnectBackground.Name = "pbConnectBackground"
        Me.pbConnectBackground.Size = New System.Drawing.Size(615, 790)
        Me.pbConnectBackground.TabIndex = 62
        Me.pbConnectBackground.TabStop = False
        '
        'pbConnectGif
        '
        Me.pbConnectGif.BackColor = System.Drawing.Color.Gray
        Me.pbConnectGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbConnectGif.Image = Global.JobBot.My.Resources.Resources.ConnectGIF
        Me.pbConnectGif.Location = New System.Drawing.Point(474, 169)
        Me.pbConnectGif.Margin = New System.Windows.Forms.Padding(0)
        Me.pbConnectGif.Name = "pbConnectGif"
        Me.pbConnectGif.Size = New System.Drawing.Size(500, 500)
        Me.pbConnectGif.TabIndex = 61
        Me.pbConnectGif.TabStop = False
        '
        'ConnectPanel
        '
        Me.ConnectPanel.Controls.Add(Me.pbConnectGif)
        Me.ConnectPanel.Controls.Add(Me.pbConnectBackground)
        Me.ConnectPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConnectPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConnectPanel.Name = "ConnectPanel"
        Me.ConnectPanel.Size = New System.Drawing.Size(1513, 830)
        Me.ConnectPanel.TabIndex = 60
        Me.ConnectPanel.Visible = False
        '
        'pbMainBackground
        '
        Me.pbMainBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbMainBackground.ContextMenuStrip = Me.cmsMenyy
        Me.pbMainBackground.Image = Global.JobBot.My.Resources.Resources.MainBackground
        Me.pbMainBackground.Location = New System.Drawing.Point(0, 0)
        Me.pbMainBackground.Name = "pbMainBackground"
        Me.pbMainBackground.Size = New System.Drawing.Size(1462, 790)
        Me.pbMainBackground.TabIndex = 0
        Me.pbMainBackground.TabStop = False
        '
        'pbGIF
        '
        Me.pbGIF.BackColor = System.Drawing.Color.Gray
        Me.pbGIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbGIF.Image = Global.JobBot.My.Resources.Resources.StandbyGIF
        Me.pbGIF.Location = New System.Drawing.Point(486, 9)
        Me.pbGIF.Margin = New System.Windows.Forms.Padding(0)
        Me.pbGIF.Name = "pbGIF"
        Me.pbGIF.Size = New System.Drawing.Size(500, 500)
        Me.pbGIF.TabIndex = 1
        Me.pbGIF.TabStop = False
        '
        'rtbOutput
        '
        Me.rtbOutput.BackColor = System.Drawing.Color.DimGray
        Me.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbOutput.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rtbOutput.ForeColor = System.Drawing.Color.White
        Me.rtbOutput.Location = New System.Drawing.Point(231, 472)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(1050, 142)
        Me.rtbOutput.TabIndex = 2
        Me.rtbOutput.Text = ""
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.BackColor = System.Drawing.Color.Gray
        Me.cbAll.Checked = True
        Me.cbAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAll.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cbAll.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbAll.Location = New System.Drawing.Point(1262, 142)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(44, 20)
        Me.cbAll.TabIndex = 46
        Me.cbAll.Text = "ALL"
        Me.cbAll.UseVisualStyleBackColor = False
        '
        'cbMedia
        '
        Me.cbMedia.AutoSize = True
        Me.cbMedia.BackColor = System.Drawing.Color.Gray
        Me.cbMedia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cbMedia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbMedia.Location = New System.Drawing.Point(1262, 165)
        Me.cbMedia.Name = "cbMedia"
        Me.cbMedia.Size = New System.Drawing.Size(63, 20)
        Me.cbMedia.TabIndex = 47
        Me.cbMedia.Text = "Media"
        Me.cbMedia.UseVisualStyleBackColor = False
        '
        'cbInRunning
        '
        Me.cbInRunning.AutoSize = True
        Me.cbInRunning.BackColor = System.Drawing.Color.Gray
        Me.cbInRunning.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cbInRunning.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbInRunning.Location = New System.Drawing.Point(1262, 188)
        Me.cbInRunning.Name = "cbInRunning"
        Me.cbInRunning.Size = New System.Drawing.Size(81, 20)
        Me.cbInRunning.TabIndex = 48
        Me.cbInRunning.Text = "InRunning"
        Me.cbInRunning.UseVisualStyleBackColor = False
        '
        'cbResource
        '
        Me.cbResource.AutoSize = True
        Me.cbResource.BackColor = System.Drawing.Color.Gray
        Me.cbResource.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cbResource.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbResource.Location = New System.Drawing.Point(1262, 211)
        Me.cbResource.Name = "cbResource"
        Me.cbResource.Size = New System.Drawing.Size(76, 20)
        Me.cbResource.TabIndex = 49
        Me.cbResource.Text = "Resource"
        Me.cbResource.UseVisualStyleBackColor = False
        '
        'cbQC
        '
        Me.cbQC.AutoSize = True
        Me.cbQC.BackColor = System.Drawing.Color.Gray
        Me.cbQC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cbQC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbQC.Location = New System.Drawing.Point(1262, 234)
        Me.cbQC.Name = "cbQC"
        Me.cbQC.Size = New System.Drawing.Size(46, 20)
        Me.cbQC.TabIndex = 50
        Me.cbQC.Text = "QC"
        Me.cbQC.UseVisualStyleBackColor = False
        '
        'cbUATTesting
        '
        Me.cbUATTesting.AutoSize = True
        Me.cbUATTesting.BackColor = System.Drawing.Color.Gray
        Me.cbUATTesting.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cbUATTesting.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbUATTesting.Location = New System.Drawing.Point(1262, 257)
        Me.cbUATTesting.Name = "cbUATTesting"
        Me.cbUATTesting.Size = New System.Drawing.Size(83, 20)
        Me.cbUATTesting.TabIndex = 51
        Me.cbUATTesting.Text = "UATTesting"
        Me.cbUATTesting.UseVisualStyleBackColor = False
        '
        'cbBroadcasting
        '
        Me.cbBroadcasting.AutoSize = True
        Me.cbBroadcasting.BackColor = System.Drawing.Color.Gray
        Me.cbBroadcasting.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cbBroadcasting.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbBroadcasting.Location = New System.Drawing.Point(1262, 280)
        Me.cbBroadcasting.Name = "cbBroadcasting"
        Me.cbBroadcasting.Size = New System.Drawing.Size(98, 20)
        Me.cbBroadcasting.TabIndex = 52
        Me.cbBroadcasting.Text = "Broadcasting"
        Me.cbBroadcasting.UseVisualStyleBackColor = False
        '
        'lbTaskType
        '
        Me.lbTaskType.AutoSize = True
        Me.lbTaskType.BackColor = System.Drawing.Color.DimGray
        Me.lbTaskType.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbTaskType.ForeColor = System.Drawing.Color.White
        Me.lbTaskType.Location = New System.Drawing.Point(228, 456)
        Me.lbTaskType.Name = "lbTaskType"
        Me.lbTaskType.Size = New System.Drawing.Size(70, 17)
        Me.lbTaskType.TabIndex = 54
        Me.lbTaskType.Text = "Task type"
        '
        'lbEndTime
        '
        Me.lbEndTime.AutoSize = True
        Me.lbEndTime.BackColor = System.Drawing.Color.DimGray
        Me.lbEndTime.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbEndTime.ForeColor = System.Drawing.Color.White
        Me.lbEndTime.Location = New System.Drawing.Point(710, 456)
        Me.lbEndTime.Name = "lbEndTime"
        Me.lbEndTime.Size = New System.Drawing.Size(67, 17)
        Me.lbEndTime.TabIndex = 56
        Me.lbEndTime.Text = "End time"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.BackColor = System.Drawing.Color.DimGray
        Me.lbTotal.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.White
        Me.lbTotal.Location = New System.Drawing.Point(950, 456)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(40, 17)
        Me.lbTotal.TabIndex = 57
        Me.lbTotal.Text = "Total"
        '
        'lbRegisterd
        '
        Me.lbRegisterd.AutoSize = True
        Me.lbRegisterd.BackColor = System.Drawing.Color.DimGray
        Me.lbRegisterd.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbRegisterd.ForeColor = System.Drawing.Color.White
        Me.lbRegisterd.Location = New System.Drawing.Point(1094, 456)
        Me.lbRegisterd.Name = "lbRegisterd"
        Me.lbRegisterd.Size = New System.Drawing.Size(70, 17)
        Me.lbRegisterd.TabIndex = 58
        Me.lbRegisterd.Text = "Registerd"
        '
        'lbStartTime
        '
        Me.lbStartTime.AutoSize = True
        Me.lbStartTime.BackColor = System.Drawing.Color.DimGray
        Me.lbStartTime.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbStartTime.ForeColor = System.Drawing.Color.White
        Me.lbStartTime.Location = New System.Drawing.Point(471, 456)
        Me.lbStartTime.Name = "lbStartTime"
        Me.lbStartTime.Size = New System.Drawing.Size(71, 17)
        Me.lbStartTime.TabIndex = 55
        Me.lbStartTime.Text = "Start time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbCounter
        '
        Me.lbCounter.BackColor = System.Drawing.Color.DimGray
        Me.lbCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbCounter.ForeColor = System.Drawing.Color.White
        Me.lbCounter.Location = New System.Drawing.Point(486, 215)
        Me.lbCounter.Name = "lbCounter"
        Me.lbCounter.Size = New System.Drawing.Size(500, 39)
        Me.lbCounter.TabIndex = 59
        Me.lbCounter.Text = "0"
        Me.lbCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbCounter.Visible = False
        '
        'pbStartStop
        '
        Me.pbStartStop.BackColor = System.Drawing.Color.YellowGreen
        Me.pbStartStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbStartStop.Image = Global.JobBot.My.Resources.Resources.Start
        Me.pbStartStop.Location = New System.Drawing.Point(62, 215)
        Me.pbStartStop.Name = "pbStartStop"
        Me.pbStartStop.Size = New System.Drawing.Size(174, 59)
        Me.pbStartStop.TabIndex = 61
        Me.pbStartStop.TabStop = False
        '
        'pbCalendar
        '
        Me.pbCalendar.BackColor = System.Drawing.Color.YellowGreen
        Me.pbCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCalendar.Image = Global.JobBot.My.Resources.Resources.Calendar
        Me.pbCalendar.Location = New System.Drawing.Point(62, 146)
        Me.pbCalendar.Name = "pbCalendar"
        Me.pbCalendar.Size = New System.Drawing.Size(174, 59)
        Me.pbCalendar.TabIndex = 62
        Me.pbCalendar.TabStop = False
        '
        'lbTaskType2
        '
        Me.lbTaskType2.AutoSize = True
        Me.lbTaskType2.BackColor = System.Drawing.Color.DimGray
        Me.lbTaskType2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbTaskType2.ForeColor = System.Drawing.Color.White
        Me.lbTaskType2.Location = New System.Drawing.Point(1259, 122)
        Me.lbTaskType2.Name = "lbTaskType2"
        Me.lbTaskType2.Size = New System.Drawing.Size(70, 17)
        Me.lbTaskType2.TabIndex = 63
        Me.lbTaskType2.Text = "Task type"
        '
        'lbMainError
        '
        Me.lbMainError.BackColor = System.Drawing.Color.Gray
        Me.lbMainError.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbMainError.ForeColor = System.Drawing.Color.DarkRed
        Me.lbMainError.Location = New System.Drawing.Point(486, 399)
        Me.lbMainError.Name = "lbMainError"
        Me.lbMainError.Size = New System.Drawing.Size(500, 57)
        Me.lbMainError.TabIndex = 64
        Me.lbMainError.Text = "ERROR"
        Me.lbMainError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbMainError.Visible = False
        '
        'lbOfflineTimeMain
        '
        Me.lbOfflineTimeMain.AutoSize = True
        Me.lbOfflineTimeMain.BackColor = System.Drawing.Color.DimGray
        Me.lbOfflineTimeMain.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbOfflineTimeMain.ForeColor = System.Drawing.Color.DarkRed
        Me.lbOfflineTimeMain.Location = New System.Drawing.Point(260, 347)
        Me.lbOfflineTimeMain.Name = "lbOfflineTimeMain"
        Me.lbOfflineTimeMain.Size = New System.Drawing.Size(23, 32)
        Me.lbOfflineTimeMain.TabIndex = 67
        Me.lbOfflineTimeMain.Text = " "
        '
        'lbOnlineTimeMain
        '
        Me.lbOnlineTimeMain.AutoSize = True
        Me.lbOnlineTimeMain.BackColor = System.Drawing.Color.DimGray
        Me.lbOnlineTimeMain.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbOnlineTimeMain.ForeColor = System.Drawing.Color.DarkRed
        Me.lbOnlineTimeMain.Location = New System.Drawing.Point(260, 304)
        Me.lbOnlineTimeMain.Name = "lbOnlineTimeMain"
        Me.lbOnlineTimeMain.Size = New System.Drawing.Size(23, 32)
        Me.lbOnlineTimeMain.TabIndex = 68
        Me.lbOnlineTimeMain.Text = " "
        '
        'lbExit
        '
        Me.lbExit.AutoSize = True
        Me.lbExit.BackColor = System.Drawing.Color.Gray
        Me.lbExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbExit.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbExit.ForeColor = System.Drawing.Color.White
        Me.lbExit.Location = New System.Drawing.Point(1420, 93)
        Me.lbExit.Name = "lbExit"
        Me.lbExit.Size = New System.Drawing.Size(32, 19)
        Me.lbExit.TabIndex = 69
        Me.lbExit.Text = "Exit"
        '
        'lbMinimize
        '
        Me.lbMinimize.AutoSize = True
        Me.lbMinimize.BackColor = System.Drawing.Color.Gray
        Me.lbMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbMinimize.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbMinimize.ForeColor = System.Drawing.Color.White
        Me.lbMinimize.Location = New System.Drawing.Point(1346, 93)
        Me.lbMinimize.Name = "lbMinimize"
        Me.lbMinimize.Size = New System.Drawing.Size(68, 19)
        Me.lbMinimize.TabIndex = 70
        Me.lbMinimize.Text = "Minimize"
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.lbMinimize)
        Me.MainPanel.Controls.Add(Me.lbExit)
        Me.MainPanel.Controls.Add(Me.lbOnlineTimeMain)
        Me.MainPanel.Controls.Add(Me.lbOfflineTimeMain)
        Me.MainPanel.Controls.Add(Me.lbMainError)
        Me.MainPanel.Controls.Add(Me.lbTaskType2)
        Me.MainPanel.Controls.Add(Me.pbCalendar)
        Me.MainPanel.Controls.Add(Me.pbStartStop)
        Me.MainPanel.Controls.Add(Me.lbCounter)
        Me.MainPanel.Controls.Add(Me.lbStartTime)
        Me.MainPanel.Controls.Add(Me.lbRegisterd)
        Me.MainPanel.Controls.Add(Me.lbTotal)
        Me.MainPanel.Controls.Add(Me.lbEndTime)
        Me.MainPanel.Controls.Add(Me.lbTaskType)
        Me.MainPanel.Controls.Add(Me.cbBroadcasting)
        Me.MainPanel.Controls.Add(Me.cbUATTesting)
        Me.MainPanel.Controls.Add(Me.cbQC)
        Me.MainPanel.Controls.Add(Me.cbResource)
        Me.MainPanel.Controls.Add(Me.cbInRunning)
        Me.MainPanel.Controls.Add(Me.cbMedia)
        Me.MainPanel.Controls.Add(Me.cbAll)
        Me.MainPanel.Controls.Add(Me.rtbOutput)
        Me.MainPanel.Controls.Add(Me.pbGIF)
        Me.MainPanel.Controls.Add(Me.pbMainBackground)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.ForeColor = System.Drawing.Color.LawnGreen
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1513, 830)
        Me.MainPanel.TabIndex = 59
        Me.MainPanel.Visible = False
        '
        'pbCalendarBackground
        '
        Me.pbCalendarBackground.ContextMenuStrip = Me.cmsMenyy
        Me.pbCalendarBackground.Image = Global.JobBot.My.Resources.Resources.CalendarBackground
        Me.pbCalendarBackground.Location = New System.Drawing.Point(78, 0)
        Me.pbCalendarBackground.Name = "pbCalendarBackground"
        Me.pbCalendarBackground.Size = New System.Drawing.Size(1301, 790)
        Me.pbCalendarBackground.TabIndex = 0
        Me.pbCalendarBackground.TabStop = False
        '
        'clbTimes
        '
        Me.clbTimes.BackColor = System.Drawing.Color.DimGray
        Me.clbTimes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbTimes.CheckOnClick = True
        Me.clbTimes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.clbTimes.ForeColor = System.Drawing.SystemColors.Info
        Me.clbTimes.FormattingEnabled = True
        Me.clbTimes.Location = New System.Drawing.Point(567, 194)
        Me.clbTimes.Name = "clbTimes"
        Me.clbTimes.Size = New System.Drawing.Size(360, 416)
        Me.clbTimes.TabIndex = 2
        '
        'lbDateStartTime
        '
        Me.lbDateStartTime.AutoSize = True
        Me.lbDateStartTime.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbDateStartTime.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbDateStartTime.ForeColor = System.Drawing.Color.White
        Me.lbDateStartTime.Location = New System.Drawing.Point(588, 168)
        Me.lbDateStartTime.Name = "lbDateStartTime"
        Me.lbDateStartTime.Size = New System.Drawing.Size(102, 23)
        Me.lbDateStartTime.TabIndex = 3
        Me.lbDateStartTime.Text = "Start time"
        '
        'lbDateEndTime
        '
        Me.lbDateEndTime.AutoSize = True
        Me.lbDateEndTime.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbDateEndTime.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbDateEndTime.ForeColor = System.Drawing.Color.White
        Me.lbDateEndTime.Location = New System.Drawing.Point(792, 168)
        Me.lbDateEndTime.Name = "lbDateEndTime"
        Me.lbDateEndTime.Size = New System.Drawing.Size(95, 23)
        Me.lbDateEndTime.TabIndex = 4
        Me.lbDateEndTime.Text = "End time"
        '
        'dtpStartDateTime
        '
        Me.dtpStartDateTime.CustomFormat = "dddd:    dd.MM.yyyy       HH:mm"
        Me.dtpStartDateTime.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtpStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDateTime.Location = New System.Drawing.Point(302, 347)
        Me.dtpStartDateTime.Name = "dtpStartDateTime"
        Me.dtpStartDateTime.Size = New System.Drawing.Size(224, 21)
        Me.dtpStartDateTime.TabIndex = 5
        '
        'lbStartD
        '
        Me.lbStartD.AutoSize = True
        Me.lbStartD.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbStartD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbStartD.ForeColor = System.Drawing.Color.White
        Me.lbStartD.Location = New System.Drawing.Point(379, 328)
        Me.lbStartD.Name = "lbStartD"
        Me.lbStartD.Size = New System.Drawing.Size(35, 16)
        Me.lbStartD.TabIndex = 7
        Me.lbStartD.Text = "Date"
        '
        'lbStartT
        '
        Me.lbStartT.AutoSize = True
        Me.lbStartT.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbStartT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbStartT.ForeColor = System.Drawing.Color.White
        Me.lbStartT.Location = New System.Drawing.Point(455, 328)
        Me.lbStartT.Name = "lbStartT"
        Me.lbStartT.Size = New System.Drawing.Size(32, 16)
        Me.lbStartT.TabIndex = 8
        Me.lbStartT.Text = "Time"
        '
        'dtpEndDateTime
        '
        Me.dtpEndDateTime.CustomFormat = "dddd:    dd.MM.yyyy       HH:mm"
        Me.dtpEndDateTime.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtpEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDateTime.Location = New System.Drawing.Point(302, 432)
        Me.dtpEndDateTime.Name = "dtpEndDateTime"
        Me.dtpEndDateTime.Size = New System.Drawing.Size(224, 21)
        Me.dtpEndDateTime.TabIndex = 9
        '
        'lbEndD
        '
        Me.lbEndD.AutoSize = True
        Me.lbEndD.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbEndD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbEndD.ForeColor = System.Drawing.Color.White
        Me.lbEndD.Location = New System.Drawing.Point(379, 413)
        Me.lbEndD.Name = "lbEndD"
        Me.lbEndD.Size = New System.Drawing.Size(35, 16)
        Me.lbEndD.TabIndex = 10
        Me.lbEndD.Text = "Date"
        '
        'lbEndT
        '
        Me.lbEndT.AutoSize = True
        Me.lbEndT.BackColor = System.Drawing.Color.Gray
        Me.lbEndT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbEndT.ForeColor = System.Drawing.Color.White
        Me.lbEndT.Location = New System.Drawing.Point(455, 413)
        Me.lbEndT.Name = "lbEndT"
        Me.lbEndT.Size = New System.Drawing.Size(32, 16)
        Me.lbEndT.TabIndex = 11
        Me.lbEndT.Text = "Time"
        '
        'lbStartDT
        '
        Me.lbStartDT.AutoSize = True
        Me.lbStartDT.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbStartDT.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbStartDT.ForeColor = System.Drawing.Color.White
        Me.lbStartDT.Location = New System.Drawing.Point(160, 347)
        Me.lbStartDT.Name = "lbStartDT"
        Me.lbStartDT.Size = New System.Drawing.Size(145, 19)
        Me.lbStartDT.TabIndex = 12
        Me.lbStartDT.Text = "Start date and time"
        '
        'lbEndDT
        '
        Me.lbEndDT.AutoSize = True
        Me.lbEndDT.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbEndDT.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbEndDT.ForeColor = System.Drawing.Color.White
        Me.lbEndDT.Location = New System.Drawing.Point(160, 432)
        Me.lbEndDT.Name = "lbEndDT"
        Me.lbEndDT.Size = New System.Drawing.Size(141, 19)
        Me.lbEndDT.TabIndex = 13
        Me.lbEndDT.Text = "End date and time"
        '
        'pbAddTime
        '
        Me.pbAddTime.BackColor = System.Drawing.Color.YellowGreen
        Me.pbAddTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAddTime.Image = Global.JobBot.My.Resources.Resources.Add
        Me.pbAddTime.Location = New System.Drawing.Point(977, 304)
        Me.pbAddTime.Name = "pbAddTime"
        Me.pbAddTime.Size = New System.Drawing.Size(174, 59)
        Me.pbAddTime.TabIndex = 62
        Me.pbAddTime.TabStop = False
        '
        'pbRemoveTime
        '
        Me.pbRemoveTime.BackColor = System.Drawing.Color.YellowGreen
        Me.pbRemoveTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRemoveTime.Image = Global.JobBot.My.Resources.Resources.Remove
        Me.pbRemoveTime.Location = New System.Drawing.Point(977, 370)
        Me.pbRemoveTime.Name = "pbRemoveTime"
        Me.pbRemoveTime.Size = New System.Drawing.Size(174, 59)
        Me.pbRemoveTime.TabIndex = 63
        Me.pbRemoveTime.TabStop = False
        '
        'pbFinish
        '
        Me.pbFinish.BackColor = System.Drawing.Color.YellowGreen
        Me.pbFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFinish.Image = Global.JobBot.My.Resources.Resources.Finish
        Me.pbFinish.Location = New System.Drawing.Point(977, 436)
        Me.pbFinish.Name = "pbFinish"
        Me.pbFinish.Size = New System.Drawing.Size(174, 59)
        Me.pbFinish.TabIndex = 64
        Me.pbFinish.TabStop = False
        '
        'lbCalendarError
        '
        Me.lbCalendarError.BackColor = System.Drawing.Color.Gray
        Me.lbCalendarError.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbCalendarError.ForeColor = System.Drawing.Color.DarkRed
        Me.lbCalendarError.Location = New System.Drawing.Point(308, 471)
        Me.lbCalendarError.Name = "lbCalendarError"
        Me.lbCalendarError.Size = New System.Drawing.Size(232, 65)
        Me.lbCalendarError.TabIndex = 65
        Me.lbCalendarError.Text = "ERROR"
        Me.lbCalendarError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbCalendarError.Visible = False
        '
        'lbOfflineTimeCalendar
        '
        Me.lbOfflineTimeCalendar.AutoSize = True
        Me.lbOfflineTimeCalendar.BackColor = System.Drawing.Color.DimGray
        Me.lbOfflineTimeCalendar.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbOfflineTimeCalendar.ForeColor = System.Drawing.Color.DarkRed
        Me.lbOfflineTimeCalendar.Location = New System.Drawing.Point(376, 280)
        Me.lbOfflineTimeCalendar.Name = "lbOfflineTimeCalendar"
        Me.lbOfflineTimeCalendar.Size = New System.Drawing.Size(23, 32)
        Me.lbOfflineTimeCalendar.TabIndex = 66
        Me.lbOfflineTimeCalendar.Text = " "
        '
        'lbOnlineTimeCalendar
        '
        Me.lbOnlineTimeCalendar.AutoSize = True
        Me.lbOnlineTimeCalendar.BackColor = System.Drawing.Color.DimGray
        Me.lbOnlineTimeCalendar.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbOnlineTimeCalendar.ForeColor = System.Drawing.Color.DarkRed
        Me.lbOnlineTimeCalendar.Location = New System.Drawing.Point(376, 238)
        Me.lbOnlineTimeCalendar.Name = "lbOnlineTimeCalendar"
        Me.lbOnlineTimeCalendar.Size = New System.Drawing.Size(23, 32)
        Me.lbOnlineTimeCalendar.TabIndex = 67
        Me.lbOnlineTimeCalendar.Text = " "
        '
        'lbExitCalendar
        '
        Me.lbExitCalendar.AutoSize = True
        Me.lbExitCalendar.BackColor = System.Drawing.Color.Gray
        Me.lbExitCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbExitCalendar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbExitCalendar.ForeColor = System.Drawing.Color.White
        Me.lbExitCalendar.Location = New System.Drawing.Point(973, 104)
        Me.lbExitCalendar.Name = "lbExitCalendar"
        Me.lbExitCalendar.Size = New System.Drawing.Size(32, 19)
        Me.lbExitCalendar.TabIndex = 71
        Me.lbExitCalendar.Text = "Exit"
        '
        'lbMinimizeCalendar
        '
        Me.lbMinimizeCalendar.AutoSize = True
        Me.lbMinimizeCalendar.BackColor = System.Drawing.Color.Gray
        Me.lbMinimizeCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbMinimizeCalendar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbMinimizeCalendar.ForeColor = System.Drawing.Color.White
        Me.lbMinimizeCalendar.Location = New System.Drawing.Point(899, 104)
        Me.lbMinimizeCalendar.Name = "lbMinimizeCalendar"
        Me.lbMinimizeCalendar.Size = New System.Drawing.Size(68, 19)
        Me.lbMinimizeCalendar.TabIndex = 72
        Me.lbMinimizeCalendar.Text = "Minimize"
        '
        'CalendarPanel
        '
        Me.CalendarPanel.Controls.Add(Me.lbMinimizeCalendar)
        Me.CalendarPanel.Controls.Add(Me.lbExitCalendar)
        Me.CalendarPanel.Controls.Add(Me.lbOnlineTimeCalendar)
        Me.CalendarPanel.Controls.Add(Me.lbOfflineTimeCalendar)
        Me.CalendarPanel.Controls.Add(Me.lbCalendarError)
        Me.CalendarPanel.Controls.Add(Me.pbFinish)
        Me.CalendarPanel.Controls.Add(Me.pbRemoveTime)
        Me.CalendarPanel.Controls.Add(Me.pbAddTime)
        Me.CalendarPanel.Controls.Add(Me.lbEndDT)
        Me.CalendarPanel.Controls.Add(Me.lbStartDT)
        Me.CalendarPanel.Controls.Add(Me.lbEndT)
        Me.CalendarPanel.Controls.Add(Me.lbEndD)
        Me.CalendarPanel.Controls.Add(Me.dtpEndDateTime)
        Me.CalendarPanel.Controls.Add(Me.lbStartT)
        Me.CalendarPanel.Controls.Add(Me.lbStartD)
        Me.CalendarPanel.Controls.Add(Me.dtpStartDateTime)
        Me.CalendarPanel.Controls.Add(Me.lbDateEndTime)
        Me.CalendarPanel.Controls.Add(Me.lbDateStartTime)
        Me.CalendarPanel.Controls.Add(Me.clbTimes)
        Me.CalendarPanel.Controls.Add(Me.pbCalendarBackground)
        Me.CalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalendarPanel.Location = New System.Drawing.Point(0, 0)
        Me.CalendarPanel.Name = "CalendarPanel"
        Me.CalendarPanel.Size = New System.Drawing.Size(1513, 830)
        Me.CalendarPanel.TabIndex = 60
        Me.CalendarPanel.Visible = False
        '
        'pbWidgetBackground
        '
        Me.pbWidgetBackground.ContextMenuStrip = Me.cmsMenyy
        Me.pbWidgetBackground.Image = Global.JobBot.My.Resources.Resources.WidgetBackground
        Me.pbWidgetBackground.Location = New System.Drawing.Point(567, 204)
        Me.pbWidgetBackground.Name = "pbWidgetBackground"
        Me.pbWidgetBackground.Size = New System.Drawing.Size(374, 196)
        Me.pbWidgetBackground.TabIndex = 0
        Me.pbWidgetBackground.TabStop = False
        '
        'pbSearchSmallGIF
        '
        Me.pbSearchSmallGIF.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbSearchSmallGIF.ContextMenuStrip = Me.cmsMenyy
        Me.pbSearchSmallGIF.Image = Global.JobBot.My.Resources.Resources.SearchSmallGIF
        Me.pbSearchSmallGIF.Location = New System.Drawing.Point(583, 243)
        Me.pbSearchSmallGIF.Name = "pbSearchSmallGIF"
        Me.pbSearchSmallGIF.Size = New System.Drawing.Size(125, 125)
        Me.pbSearchSmallGIF.TabIndex = 1
        Me.pbSearchSmallGIF.TabStop = False
        '
        'lbWidgetRefreshCounter
        '
        Me.lbWidgetRefreshCounter.AutoSize = True
        Me.lbWidgetRefreshCounter.BackColor = System.Drawing.Color.DimGray
        Me.lbWidgetRefreshCounter.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbWidgetRefreshCounter.Location = New System.Drawing.Point(761, 303)
        Me.lbWidgetRefreshCounter.Name = "lbWidgetRefreshCounter"
        Me.lbWidgetRefreshCounter.Size = New System.Drawing.Size(16, 17)
        Me.lbWidgetRefreshCounter.TabIndex = 2
        Me.lbWidgetRefreshCounter.Text = "0"
        '
        'lbWidgetTaskCounter
        '
        Me.lbWidgetTaskCounter.AutoSize = True
        Me.lbWidgetTaskCounter.BackColor = System.Drawing.Color.DimGray
        Me.lbWidgetTaskCounter.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbWidgetTaskCounter.Location = New System.Drawing.Point(747, 327)
        Me.lbWidgetTaskCounter.Name = "lbWidgetTaskCounter"
        Me.lbWidgetTaskCounter.Size = New System.Drawing.Size(16, 17)
        Me.lbWidgetTaskCounter.TabIndex = 3
        Me.lbWidgetTaskCounter.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(703, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Refresh:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(703, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tasks:"
        '
        'lbExitWidget
        '
        Me.lbExitWidget.AutoSize = True
        Me.lbExitWidget.BackColor = System.Drawing.Color.DimGray
        Me.lbExitWidget.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbExitWidget.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbExitWidget.ForeColor = System.Drawing.Color.White
        Me.lbExitWidget.Location = New System.Drawing.Point(850, 320)
        Me.lbExitWidget.Name = "lbExitWidget"
        Me.lbExitWidget.Size = New System.Drawing.Size(32, 19)
        Me.lbExitWidget.TabIndex = 75
        Me.lbExitWidget.Text = "Exit"
        '
        'lbMaximizeWidget
        '
        Me.lbMaximizeWidget.AutoSize = True
        Me.lbMaximizeWidget.BackColor = System.Drawing.Color.DimGray
        Me.lbMaximizeWidget.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbMaximizeWidget.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbMaximizeWidget.ForeColor = System.Drawing.Color.White
        Me.lbMaximizeWidget.Location = New System.Drawing.Point(850, 301)
        Me.lbMaximizeWidget.Name = "lbMaximizeWidget"
        Me.lbMaximizeWidget.Size = New System.Drawing.Size(73, 19)
        Me.lbMaximizeWidget.TabIndex = 76
        Me.lbMaximizeWidget.Text = "Maximize"
        '
        'WidgetPanel
        '
        Me.WidgetPanel.Controls.Add(Me.lbMaximizeWidget)
        Me.WidgetPanel.Controls.Add(Me.lbExitWidget)
        Me.WidgetPanel.Controls.Add(Me.Label1)
        Me.WidgetPanel.Controls.Add(Me.Label2)
        Me.WidgetPanel.Controls.Add(Me.lbWidgetTaskCounter)
        Me.WidgetPanel.Controls.Add(Me.lbWidgetRefreshCounter)
        Me.WidgetPanel.Controls.Add(Me.pbSearchSmallGIF)
        Me.WidgetPanel.Controls.Add(Me.pbWidgetBackground)
        Me.WidgetPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WidgetPanel.Location = New System.Drawing.Point(0, 0)
        Me.WidgetPanel.Name = "WidgetPanel"
        Me.WidgetPanel.Size = New System.Drawing.Size(1513, 830)
        Me.WidgetPanel.TabIndex = 60
        Me.WidgetPanel.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1513, 830)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.WidgetPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.CalendarPanel)
        Me.Controls.Add(Me.ConnectPanel)
        Me.Controls.Add(Me.BrauserPanel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "R&G"
        Me.TransparencyKey = System.Drawing.Color.Green
        Me.cmsMenyy.ResumeLayout(False)
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoginBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BrauserPanel.ResumeLayout(False)
        CType(Me.pbConnectBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConnectGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConnectPanel.ResumeLayout(False)
        CType(Me.pbMainBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStartStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.pbCalendarBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRemoveTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFinish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CalendarPanel.ResumeLayout(False)
        Me.CalendarPanel.PerformLayout()
        CType(Me.pbWidgetBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSearchSmallGIF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WidgetPanel.ResumeLayout(False)
        Me.WidgetPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents pbLoginBackground As PictureBox
    Friend WithEvents tbUserId As TextBox
    Friend WithEvents tbUserPassword As TextBox
    Friend WithEvents lbMail As Label
    Friend WithEvents lbLoginError As Label
    Friend WithEvents timeCheckIn As Timer
    Friend WithEvents cmsMenyy As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bwLogin As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwScan As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbLogin As PictureBox
    Friend WithEvents lbOfflineTime As Label
    Friend WithEvents timeOnline As Timer
    Friend WithEvents timeOffline As Timer
    Friend WithEvents MaximizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbMinimizeLogin As Label
    Friend WithEvents lbExitLogin As Label
    Friend WithEvents wbBrowser2 As WebBrowser
    Friend WithEvents wbBrowser1 As WebBrowser
    Friend WithEvents BrauserPanel As Panel
    Friend WithEvents pbConnectBackground As PictureBox
    Friend WithEvents pbConnectGif As PictureBox
    Friend WithEvents ConnectPanel As Panel
    Friend WithEvents pbMainBackground As PictureBox
    Friend WithEvents pbGIF As PictureBox
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents cbAll As CheckBox
    Friend WithEvents cbMedia As CheckBox
    Friend WithEvents cbInRunning As CheckBox
    Friend WithEvents cbResource As CheckBox
    Friend WithEvents cbQC As CheckBox
    Friend WithEvents cbUATTesting As CheckBox
    Friend WithEvents cbBroadcasting As CheckBox
    Friend WithEvents lbTaskType As Label
    Friend WithEvents lbEndTime As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents lbRegisterd As Label
    Friend WithEvents lbStartTime As Label
    Friend WithEvents lbCounter As Label
    Friend WithEvents pbStartStop As PictureBox
    Friend WithEvents pbCalendar As PictureBox
    Friend WithEvents lbTaskType2 As Label
    Friend WithEvents lbMainError As Label
    Friend WithEvents lbOfflineTimeMain As Label
    Friend WithEvents lbOnlineTimeMain As Label
    Friend WithEvents lbExit As Label
    Friend WithEvents lbMinimize As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents pbCalendarBackground As PictureBox
    Friend WithEvents clbTimes As CheckedListBox
    Friend WithEvents lbDateStartTime As Label
    Friend WithEvents lbDateEndTime As Label
    Friend WithEvents dtpStartDateTime As DateTimePicker
    Friend WithEvents lbStartD As Label
    Friend WithEvents lbStartT As Label
    Friend WithEvents dtpEndDateTime As DateTimePicker
    Friend WithEvents lbEndD As Label
    Friend WithEvents lbEndT As Label
    Friend WithEvents lbStartDT As Label
    Friend WithEvents lbEndDT As Label
    Friend WithEvents pbAddTime As PictureBox
    Friend WithEvents pbRemoveTime As PictureBox
    Friend WithEvents pbFinish As PictureBox
    Friend WithEvents lbCalendarError As Label
    Friend WithEvents lbOfflineTimeCalendar As Label
    Friend WithEvents lbOnlineTimeCalendar As Label
    Friend WithEvents lbExitCalendar As Label
    Friend WithEvents lbMinimizeCalendar As Label
    Friend WithEvents CalendarPanel As Panel
    Friend WithEvents pbWidgetBackground As PictureBox
    Friend WithEvents pbSearchSmallGIF As PictureBox
    Friend WithEvents lbWidgetRefreshCounter As Label
    Friend WithEvents lbWidgetTaskCounter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbExitWidget As Label
    Friend WithEvents lbMaximizeWidget As Label
    Friend WithEvents WidgetPanel As Panel
End Class
