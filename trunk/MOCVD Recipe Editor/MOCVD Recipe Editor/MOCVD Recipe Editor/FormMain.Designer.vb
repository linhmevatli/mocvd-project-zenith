﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NumericUpDown_Time = New System.Windows.Forms.NumericUpDown()
		Me.Label_Time = New System.Windows.Forms.Label()
		Me.Label_Ramp = New System.Windows.Forms.Label()
		Me.Label_Delay = New System.Windows.Forms.Label()
		Me.NumericUpDown_Ramp = New System.Windows.Forms.NumericUpDown()
		Me.NumericUpDown_Delay = New System.Windows.Forms.NumericUpDown()
		Me.ComboBox_TimeUnits = New System.Windows.Forms.ComboBox()
		Me.ComboBox_RampUnits = New System.Windows.Forms.ComboBox()
		Me.ComboBox_DelayUnits = New System.Windows.Forms.ComboBox()
		Me.Button_AddStep = New System.Windows.Forms.Button()
		Me.GroupBoxValves = New System.Windows.Forms.GroupBox()
		Me.ListView_ValveList = New System.Windows.Forms.ListView()
		Me.ColumnHeaderValve = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeaderAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ContextMenuStrip_ValveList = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.SetToOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SetToCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RemoveItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Button_AddValve = New System.Windows.Forms.Button()
		Me.RadioButton_ValveClose = New System.Windows.Forms.RadioButton()
		Me.RadioButton_ValveOpen = New System.Windows.Forms.RadioButton()
		Me.LabelValveIndex = New System.Windows.Forms.Label()
		Me.NumericUpDownValveIndex = New System.Windows.Forms.NumericUpDown()
		Me.GroupBoxTiming = New System.Windows.Forms.GroupBox()
		Me.ListView_Steps = New System.Windows.Forms.ListView()
		Me.ColumnHeader_StepIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepRamp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepDelay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepValves = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepMFCs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.DataSocketServer1 = New NationalInstruments.Net.DataSocketServer(Me.components)
		Me.GroupBox_MFCs = New System.Windows.Forms.GroupBox()
		Me.ListView_MFCsList = New System.Windows.Forms.ListView()
		Me.ColumnHeader_MFC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_SetPoint = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Button_MFCs = New System.Windows.Forms.Button()
		Me.Label_MFCsSetPoint = New System.Windows.Forms.Label()
		Me.NumericUpDown_MFCsSetPoint = New System.Windows.Forms.NumericUpDown()
		Me.Label_MFCsIndex = New System.Windows.Forms.Label()
		Me.NumericUpDown_MFCsIndex = New System.Windows.Forms.NumericUpDown()
		Me.TextBox_StepName = New System.Windows.Forms.TextBox()
		Me.Label_StepName = New System.Windows.Forms.Label()
		Me.Label_StepDescription = New System.Windows.Forms.Label()
		Me.TextBox_StepDescription = New System.Windows.Forms.TextBox()
		Me.ListView_Routines = New System.Windows.Forms.ListView()
		Me.ColumnHeader_RoutineIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_RoutineName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_RoutineDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_RoutineSteps = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Button_AddRoutine = New System.Windows.Forms.Button()
		Me.GroupBox_StepDetails = New System.Windows.Forms.GroupBox()
		Me.GroupBox_RoutineDetails = New System.Windows.Forms.GroupBox()
		Me.TextBox_RoutineDescription = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox_RoutineName = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button_StepsUpdateChanges = New System.Windows.Forms.Button()
		Me.Button_ShowSteps = New System.Windows.Forms.Button()
		Me.ButtonLoadRoutine = New System.Windows.Forms.Button()
		Me.Button_RoutineUpdateChanges = New System.Windows.Forms.Button()
		Me.Button_StepIndexUp = New System.Windows.Forms.Button()
		Me.Button_StepIndexDown = New System.Windows.Forms.Button()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.NumericUpDown_Time, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDown_Ramp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxValves.SuspendLayout()
		Me.ContextMenuStrip_ValveList.SuspendLayout()
		CType(Me.NumericUpDownValveIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxTiming.SuspendLayout()
		CType(Me.DataSocketServer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox_MFCs.SuspendLayout()
		CType(Me.NumericUpDown_MFCsSetPoint, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDown_MFCsIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox_StepDetails.SuspendLayout()
		Me.GroupBox_RoutineDetails.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1134, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.NewToolStripMenuItem.Text = "&New"
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
		Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.OpenToolStripMenuItem.Text = "&Open"
		'
		'toolStripSeparator
		'
		Me.toolStripSeparator.Name = "toolStripSeparator"
		Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
		'
		'SaveToolStripMenuItem
		'
		Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
		Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.SaveToolStripMenuItem.Text = "&Save"
		'
		'SaveAsToolStripMenuItem
		'
		Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
		Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.SaveAsToolStripMenuItem.Text = "Save &As"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
		'
		'PrintToolStripMenuItem
		'
		Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
		Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
		Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.PrintToolStripMenuItem.Text = "&Print"
		'
		'PrintPreviewToolStripMenuItem
		'
		Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
		Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.ExitToolStripMenuItem.Text = "E&xit"
		'
		'EditToolStripMenuItem
		'
		Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
		Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
		Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
		Me.EditToolStripMenuItem.Text = "&Edit"
		'
		'UndoToolStripMenuItem
		'
		Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
		Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
		Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.UndoToolStripMenuItem.Text = "&Undo"
		'
		'RedoToolStripMenuItem
		'
		Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
		Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
		Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.RedoToolStripMenuItem.Text = "&Redo"
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
		'
		'CutToolStripMenuItem
		'
		Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
		Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.CutToolStripMenuItem.Text = "Cu&t"
		'
		'CopyToolStripMenuItem
		'
		Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
		Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.CopyToolStripMenuItem.Text = "&Copy"
		'
		'PasteToolStripMenuItem
		'
		Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
		Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.PasteToolStripMenuItem.Text = "&Paste"
		'
		'toolStripSeparator4
		'
		Me.toolStripSeparator4.Name = "toolStripSeparator4"
		Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
		'
		'SelectAllToolStripMenuItem
		'
		Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
		Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.SelectAllToolStripMenuItem.Text = "Select &All"
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.ToolsToolStripMenuItem.Text = "&Tools"
		'
		'CustomizeToolStripMenuItem
		'
		Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
		Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
		Me.CustomizeToolStripMenuItem.Text = "&Customize"
		'
		'OptionsToolStripMenuItem
		'
		Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
		Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
		Me.OptionsToolStripMenuItem.Text = "&Options"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem.Text = "&Help"
		'
		'ContentsToolStripMenuItem
		'
		Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
		Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.ContentsToolStripMenuItem.Text = "&Contents"
		'
		'IndexToolStripMenuItem
		'
		Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
		Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.IndexToolStripMenuItem.Text = "&Index"
		'
		'SearchToolStripMenuItem
		'
		Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
		Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.SearchToolStripMenuItem.Text = "&Search"
		'
		'toolStripSeparator5
		'
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.AboutToolStripMenuItem.Text = "&About..."
		'
		'NumericUpDown_Time
		'
		Me.NumericUpDown_Time.DecimalPlaces = 2
		Me.NumericUpDown_Time.Location = New System.Drawing.Point(54, 19)
		Me.NumericUpDown_Time.Name = "NumericUpDown_Time"
		Me.NumericUpDown_Time.Size = New System.Drawing.Size(81, 20)
		Me.NumericUpDown_Time.TabIndex = 3
		'
		'Label_Time
		'
		Me.Label_Time.AutoSize = True
		Me.Label_Time.Location = New System.Drawing.Point(19, 21)
		Me.Label_Time.Name = "Label_Time"
		Me.Label_Time.Size = New System.Drawing.Size(33, 13)
		Me.Label_Time.TabIndex = 4
		Me.Label_Time.Text = "Time:"
		'
		'Label_Ramp
		'
		Me.Label_Ramp.AutoSize = True
		Me.Label_Ramp.Location = New System.Drawing.Point(14, 47)
		Me.Label_Ramp.Name = "Label_Ramp"
		Me.Label_Ramp.Size = New System.Drawing.Size(38, 13)
		Me.Label_Ramp.TabIndex = 5
		Me.Label_Ramp.Text = "Ramp:"
		'
		'Label_Delay
		'
		Me.Label_Delay.AutoSize = True
		Me.Label_Delay.Location = New System.Drawing.Point(15, 73)
		Me.Label_Delay.Name = "Label_Delay"
		Me.Label_Delay.Size = New System.Drawing.Size(37, 13)
		Me.Label_Delay.TabIndex = 6
		Me.Label_Delay.Text = "Delay:"
		'
		'NumericUpDown_Ramp
		'
		Me.NumericUpDown_Ramp.DecimalPlaces = 2
		Me.NumericUpDown_Ramp.Location = New System.Drawing.Point(54, 45)
		Me.NumericUpDown_Ramp.Name = "NumericUpDown_Ramp"
		Me.NumericUpDown_Ramp.Size = New System.Drawing.Size(81, 20)
		Me.NumericUpDown_Ramp.TabIndex = 7
		'
		'NumericUpDown_Delay
		'
		Me.NumericUpDown_Delay.DecimalPlaces = 2
		Me.NumericUpDown_Delay.Location = New System.Drawing.Point(54, 71)
		Me.NumericUpDown_Delay.Name = "NumericUpDown_Delay"
		Me.NumericUpDown_Delay.Size = New System.Drawing.Size(81, 20)
		Me.NumericUpDown_Delay.TabIndex = 8
		'
		'ComboBox_TimeUnits
		'
		Me.ComboBox_TimeUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox_TimeUnits.FormattingEnabled = True
		Me.ComboBox_TimeUnits.Items.AddRange(New Object() {"min", "sec", "ms"})
		Me.ComboBox_TimeUnits.Location = New System.Drawing.Point(141, 19)
		Me.ComboBox_TimeUnits.MaxLength = 3
		Me.ComboBox_TimeUnits.Name = "ComboBox_TimeUnits"
		Me.ComboBox_TimeUnits.Size = New System.Drawing.Size(42, 21)
		Me.ComboBox_TimeUnits.TabIndex = 9
		'
		'ComboBox_RampUnits
		'
		Me.ComboBox_RampUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox_RampUnits.FormattingEnabled = True
		Me.ComboBox_RampUnits.Items.AddRange(New Object() {"min", "sec", "ms"})
		Me.ComboBox_RampUnits.Location = New System.Drawing.Point(141, 45)
		Me.ComboBox_RampUnits.MaxLength = 3
		Me.ComboBox_RampUnits.Name = "ComboBox_RampUnits"
		Me.ComboBox_RampUnits.Size = New System.Drawing.Size(42, 21)
		Me.ComboBox_RampUnits.TabIndex = 10
		'
		'ComboBox_DelayUnits
		'
		Me.ComboBox_DelayUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox_DelayUnits.FormattingEnabled = True
		Me.ComboBox_DelayUnits.Items.AddRange(New Object() {"min", "sec", "ms"})
		Me.ComboBox_DelayUnits.Location = New System.Drawing.Point(141, 71)
		Me.ComboBox_DelayUnits.MaxLength = 3
		Me.ComboBox_DelayUnits.Name = "ComboBox_DelayUnits"
		Me.ComboBox_DelayUnits.Size = New System.Drawing.Size(42, 21)
		Me.ComboBox_DelayUnits.TabIndex = 11
		'
		'Button_AddStep
		'
		Me.Button_AddStep.Location = New System.Drawing.Point(343, 423)
		Me.Button_AddStep.Name = "Button_AddStep"
		Me.Button_AddStep.Size = New System.Drawing.Size(192, 30)
		Me.Button_AddStep.TabIndex = 12
		Me.Button_AddStep.Text = "Add Step"
		Me.Button_AddStep.UseVisualStyleBackColor = True
		'
		'GroupBoxValves
		'
		Me.GroupBoxValves.Controls.Add(Me.ListView_ValveList)
		Me.GroupBoxValves.Controls.Add(Me.Button_AddValve)
		Me.GroupBoxValves.Controls.Add(Me.RadioButton_ValveClose)
		Me.GroupBoxValves.Controls.Add(Me.RadioButton_ValveOpen)
		Me.GroupBoxValves.Controls.Add(Me.LabelValveIndex)
		Me.GroupBoxValves.Controls.Add(Me.NumericUpDownValveIndex)
		Me.GroupBoxValves.Location = New System.Drawing.Point(835, 27)
		Me.GroupBoxValves.Name = "GroupBoxValves"
		Me.GroupBoxValves.Size = New System.Drawing.Size(141, 202)
		Me.GroupBoxValves.TabIndex = 13
		Me.GroupBoxValves.TabStop = False
		Me.GroupBoxValves.Text = "Valves"
		'
		'ListView_ValveList
		'
		Me.ListView_ValveList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderValve, Me.ColumnHeaderAction})
		Me.ListView_ValveList.ContextMenuStrip = Me.ContextMenuStrip_ValveList
		Me.ListView_ValveList.FullRowSelect = True
		Me.ListView_ValveList.Location = New System.Drawing.Point(6, 96)
		Me.ListView_ValveList.Name = "ListView_ValveList"
		Me.ListView_ValveList.Size = New System.Drawing.Size(127, 100)
		Me.ListView_ValveList.TabIndex = 15
		Me.ListView_ValveList.UseCompatibleStateImageBehavior = False
		Me.ListView_ValveList.View = System.Windows.Forms.View.Details
		'
		'ColumnHeaderValve
		'
		Me.ColumnHeaderValve.Text = "Valve"
		Me.ColumnHeaderValve.Width = 42
		'
		'ColumnHeaderAction
		'
		Me.ColumnHeaderAction.Text = "Action"
		Me.ColumnHeaderAction.Width = 43
		'
		'ContextMenuStrip_ValveList
		'
		Me.ContextMenuStrip_ValveList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetToOpenToolStripMenuItem, Me.SetToCloseToolStripMenuItem, Me.RemoveItemsToolStripMenuItem})
		Me.ContextMenuStrip_ValveList.Name = "ContextMenuStrip_ValveList"
		Me.ContextMenuStrip_ValveList.Size = New System.Drawing.Size(158, 70)
		'
		'SetToOpenToolStripMenuItem
		'
		Me.SetToOpenToolStripMenuItem.Name = "SetToOpenToolStripMenuItem"
		Me.SetToOpenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.SetToOpenToolStripMenuItem.Text = "Set to 'Open'"
		'
		'SetToCloseToolStripMenuItem
		'
		Me.SetToCloseToolStripMenuItem.Name = "SetToCloseToolStripMenuItem"
		Me.SetToCloseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.SetToCloseToolStripMenuItem.Text = "Set to 'Close'"
		'
		'RemoveItemsToolStripMenuItem
		'
		Me.RemoveItemsToolStripMenuItem.Name = "RemoveItemsToolStripMenuItem"
		Me.RemoveItemsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.RemoveItemsToolStripMenuItem.Text = "Remove Item(s)"
		'
		'Button_AddValve
		'
		Me.Button_AddValve.Location = New System.Drawing.Point(6, 67)
		Me.Button_AddValve.Name = "Button_AddValve"
		Me.Button_AddValve.Size = New System.Drawing.Size(127, 23)
		Me.Button_AddValve.TabIndex = 16
		Me.Button_AddValve.Text = "Add Valve"
		Me.Button_AddValve.UseVisualStyleBackColor = True
		'
		'RadioButton_ValveClose
		'
		Me.RadioButton_ValveClose.AutoSize = True
		Me.RadioButton_ValveClose.Checked = True
		Me.RadioButton_ValveClose.Location = New System.Drawing.Point(82, 42)
		Me.RadioButton_ValveClose.Name = "RadioButton_ValveClose"
		Me.RadioButton_ValveClose.Size = New System.Drawing.Size(51, 17)
		Me.RadioButton_ValveClose.TabIndex = 18
		Me.RadioButton_ValveClose.TabStop = True
		Me.RadioButton_ValveClose.Text = "Close"
		Me.RadioButton_ValveClose.UseVisualStyleBackColor = True
		'
		'RadioButton_ValveOpen
		'
		Me.RadioButton_ValveOpen.AutoSize = True
		Me.RadioButton_ValveOpen.Location = New System.Drawing.Point(82, 19)
		Me.RadioButton_ValveOpen.Name = "RadioButton_ValveOpen"
		Me.RadioButton_ValveOpen.Size = New System.Drawing.Size(51, 17)
		Me.RadioButton_ValveOpen.TabIndex = 17
		Me.RadioButton_ValveOpen.Text = "Open"
		Me.RadioButton_ValveOpen.UseVisualStyleBackColor = True
		'
		'LabelValveIndex
		'
		Me.LabelValveIndex.AutoSize = True
		Me.LabelValveIndex.Location = New System.Drawing.Point(16, 23)
		Me.LabelValveIndex.Name = "LabelValveIndex"
		Me.LabelValveIndex.Size = New System.Drawing.Size(36, 13)
		Me.LabelValveIndex.TabIndex = 17
		Me.LabelValveIndex.Text = "Index:"
		'
		'NumericUpDownValveIndex
		'
		Me.NumericUpDownValveIndex.Location = New System.Drawing.Point(19, 39)
		Me.NumericUpDownValveIndex.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
		Me.NumericUpDownValveIndex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NumericUpDownValveIndex.Name = "NumericUpDownValveIndex"
		Me.NumericUpDownValveIndex.Size = New System.Drawing.Size(48, 20)
		Me.NumericUpDownValveIndex.TabIndex = 16
		Me.NumericUpDownValveIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'GroupBoxTiming
		'
		Me.GroupBoxTiming.Controls.Add(Me.ComboBox_TimeUnits)
		Me.GroupBoxTiming.Controls.Add(Me.NumericUpDown_Time)
		Me.GroupBoxTiming.Controls.Add(Me.Label_Time)
		Me.GroupBoxTiming.Controls.Add(Me.Label_Ramp)
		Me.GroupBoxTiming.Controls.Add(Me.ComboBox_DelayUnits)
		Me.GroupBoxTiming.Controls.Add(Me.Label_Delay)
		Me.GroupBoxTiming.Controls.Add(Me.ComboBox_RampUnits)
		Me.GroupBoxTiming.Controls.Add(Me.NumericUpDown_Ramp)
		Me.GroupBoxTiming.Controls.Add(Me.NumericUpDown_Delay)
		Me.GroupBoxTiming.Location = New System.Drawing.Point(343, 280)
		Me.GroupBoxTiming.Name = "GroupBoxTiming"
		Me.GroupBoxTiming.Size = New System.Drawing.Size(192, 101)
		Me.GroupBoxTiming.TabIndex = 14
		Me.GroupBoxTiming.TabStop = False
		Me.GroupBoxTiming.Text = "Timing"
		'
		'ListView_Steps
		'
		Me.ListView_Steps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_StepIndex, Me.ColumnHeader_StepName, Me.ColumnHeader_StepDescription, Me.ColumnHeader_StepTime, Me.ColumnHeader_StepRamp, Me.ColumnHeader_StepDelay, Me.ColumnHeader_StepValves, Me.ColumnHeader_StepMFCs})
		Me.ListView_Steps.FullRowSelect = True
		Me.ListView_Steps.Location = New System.Drawing.Point(343, 27)
		Me.ListView_Steps.MultiSelect = False
		Me.ListView_Steps.Name = "ListView_Steps"
		Me.ListView_Steps.Size = New System.Drawing.Size(486, 247)
		Me.ListView_Steps.TabIndex = 15
		Me.ListView_Steps.UseCompatibleStateImageBehavior = False
		Me.ListView_Steps.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader_StepIndex
		'
		Me.ColumnHeader_StepIndex.Text = "Step"
		Me.ColumnHeader_StepIndex.Width = 36
		'
		'ColumnHeader_StepName
		'
		Me.ColumnHeader_StepName.Text = "Name"
		Me.ColumnHeader_StepName.Width = 52
		'
		'ColumnHeader_StepDescription
		'
		Me.ColumnHeader_StepDescription.Text = "Description"
		Me.ColumnHeader_StepDescription.Width = 66
		'
		'ColumnHeader_StepTime
		'
		Me.ColumnHeader_StepTime.Text = "Time"
		Me.ColumnHeader_StepTime.Width = 35
		'
		'ColumnHeader_StepRamp
		'
		Me.ColumnHeader_StepRamp.Text = "Ramp"
		Me.ColumnHeader_StepRamp.Width = 44
		'
		'ColumnHeader_StepDelay
		'
		Me.ColumnHeader_StepDelay.Text = "Delay"
		Me.ColumnHeader_StepDelay.Width = 40
		'
		'ColumnHeader_StepValves
		'
		Me.ColumnHeader_StepValves.Text = "Valves"
		Me.ColumnHeader_StepValves.Width = 45
		'
		'ColumnHeader_StepMFCs
		'
		Me.ColumnHeader_StepMFCs.Text = "MFCs"
		Me.ColumnHeader_StepMFCs.Width = 43
		'
		'GroupBox_MFCs
		'
		Me.GroupBox_MFCs.Controls.Add(Me.ListView_MFCsList)
		Me.GroupBox_MFCs.Controls.Add(Me.Button_MFCs)
		Me.GroupBox_MFCs.Controls.Add(Me.Label_MFCsSetPoint)
		Me.GroupBox_MFCs.Controls.Add(Me.NumericUpDown_MFCsSetPoint)
		Me.GroupBox_MFCs.Controls.Add(Me.Label_MFCsIndex)
		Me.GroupBox_MFCs.Controls.Add(Me.NumericUpDown_MFCsIndex)
		Me.GroupBox_MFCs.Location = New System.Drawing.Point(982, 27)
		Me.GroupBox_MFCs.Name = "GroupBox_MFCs"
		Me.GroupBox_MFCs.Size = New System.Drawing.Size(141, 202)
		Me.GroupBox_MFCs.TabIndex = 16
		Me.GroupBox_MFCs.TabStop = False
		Me.GroupBox_MFCs.Text = "MFCs"
		'
		'ListView_MFCsList
		'
		Me.ListView_MFCsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_MFC, Me.ColumnHeader_SetPoint})
		Me.ListView_MFCsList.ContextMenuStrip = Me.ContextMenuStrip_ValveList
		Me.ListView_MFCsList.FullRowSelect = True
		Me.ListView_MFCsList.Location = New System.Drawing.Point(6, 96)
		Me.ListView_MFCsList.Name = "ListView_MFCsList"
		Me.ListView_MFCsList.Size = New System.Drawing.Size(127, 100)
		Me.ListView_MFCsList.TabIndex = 17
		Me.ListView_MFCsList.UseCompatibleStateImageBehavior = False
		Me.ListView_MFCsList.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader_MFC
		'
		Me.ColumnHeader_MFC.Text = "MFC"
		Me.ColumnHeader_MFC.Width = 42
		'
		'ColumnHeader_SetPoint
		'
		Me.ColumnHeader_SetPoint.Text = "SetPoint"
		Me.ColumnHeader_SetPoint.Width = 52
		'
		'Button_MFCs
		'
		Me.Button_MFCs.Location = New System.Drawing.Point(6, 67)
		Me.Button_MFCs.Name = "Button_MFCs"
		Me.Button_MFCs.Size = New System.Drawing.Size(127, 23)
		Me.Button_MFCs.TabIndex = 17
		Me.Button_MFCs.Text = "Add MFC"
		Me.Button_MFCs.UseVisualStyleBackColor = True
		'
		'Label_MFCsSetPoint
		'
		Me.Label_MFCsSetPoint.AutoSize = True
		Me.Label_MFCsSetPoint.Location = New System.Drawing.Point(61, 23)
		Me.Label_MFCsSetPoint.Name = "Label_MFCsSetPoint"
		Me.Label_MFCsSetPoint.Size = New System.Drawing.Size(50, 13)
		Me.Label_MFCsSetPoint.TabIndex = 20
		Me.Label_MFCsSetPoint.Text = "SetPoint:"
		'
		'NumericUpDown_MFCsSetPoint
		'
		Me.NumericUpDown_MFCsSetPoint.Location = New System.Drawing.Point(64, 39)
		Me.NumericUpDown_MFCsSetPoint.Name = "NumericUpDown_MFCsSetPoint"
		Me.NumericUpDown_MFCsSetPoint.Size = New System.Drawing.Size(65, 20)
		Me.NumericUpDown_MFCsSetPoint.TabIndex = 17
		'
		'Label_MFCsIndex
		'
		Me.Label_MFCsIndex.AutoSize = True
		Me.Label_MFCsIndex.Location = New System.Drawing.Point(7, 23)
		Me.Label_MFCsIndex.Name = "Label_MFCsIndex"
		Me.Label_MFCsIndex.Size = New System.Drawing.Size(36, 13)
		Me.Label_MFCsIndex.TabIndex = 19
		Me.Label_MFCsIndex.Text = "Index:"
		'
		'NumericUpDown_MFCsIndex
		'
		Me.NumericUpDown_MFCsIndex.Location = New System.Drawing.Point(10, 39)
		Me.NumericUpDown_MFCsIndex.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
		Me.NumericUpDown_MFCsIndex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NumericUpDown_MFCsIndex.Name = "NumericUpDown_MFCsIndex"
		Me.NumericUpDown_MFCsIndex.Size = New System.Drawing.Size(48, 20)
		Me.NumericUpDown_MFCsIndex.TabIndex = 18
		Me.NumericUpDown_MFCsIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'TextBox_StepName
		'
		Me.TextBox_StepName.Location = New System.Drawing.Point(78, 19)
		Me.TextBox_StepName.Name = "TextBox_StepName"
		Me.TextBox_StepName.Size = New System.Drawing.Size(204, 20)
		Me.TextBox_StepName.TabIndex = 17
		'
		'Label_StepName
		'
		Me.Label_StepName.AutoSize = True
		Me.Label_StepName.Location = New System.Drawing.Point(9, 22)
		Me.Label_StepName.Name = "Label_StepName"
		Me.Label_StepName.Size = New System.Drawing.Size(63, 13)
		Me.Label_StepName.TabIndex = 19
		Me.Label_StepName.Text = "Step Name:"
		'
		'Label_StepDescription
		'
		Me.Label_StepDescription.AutoSize = True
		Me.Label_StepDescription.Location = New System.Drawing.Point(9, 49)
		Me.Label_StepDescription.Name = "Label_StepDescription"
		Me.Label_StepDescription.Size = New System.Drawing.Size(63, 13)
		Me.Label_StepDescription.TabIndex = 20
		Me.Label_StepDescription.Text = "Description:"
		'
		'TextBox_StepDescription
		'
		Me.TextBox_StepDescription.AcceptsReturn = True
		Me.TextBox_StepDescription.AcceptsTab = True
		Me.TextBox_StepDescription.Location = New System.Drawing.Point(78, 46)
		Me.TextBox_StepDescription.Multiline = True
		Me.TextBox_StepDescription.Name = "TextBox_StepDescription"
		Me.TextBox_StepDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox_StepDescription.Size = New System.Drawing.Size(204, 121)
		Me.TextBox_StepDescription.TabIndex = 21
		'
		'ListView_Routines
		'
		Me.ListView_Routines.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_RoutineIndex, Me.ColumnHeader_RoutineName, Me.ColumnHeader_RoutineDescription, Me.ColumnHeader_RoutineSteps})
		Me.ListView_Routines.FullRowSelect = True
		Me.ListView_Routines.Location = New System.Drawing.Point(12, 27)
		Me.ListView_Routines.MultiSelect = False
		Me.ListView_Routines.Name = "ListView_Routines"
		Me.ListView_Routines.Size = New System.Drawing.Size(288, 174)
		Me.ListView_Routines.TabIndex = 22
		Me.ListView_Routines.UseCompatibleStateImageBehavior = False
		Me.ListView_Routines.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader_RoutineIndex
		'
		Me.ColumnHeader_RoutineIndex.Text = "Routine"
		'
		'ColumnHeader_RoutineName
		'
		Me.ColumnHeader_RoutineName.Text = "Name"
		'
		'ColumnHeader_RoutineDescription
		'
		Me.ColumnHeader_RoutineDescription.Text = "Description"
		Me.ColumnHeader_RoutineDescription.Width = 69
		'
		'ColumnHeader_RoutineSteps
		'
		Me.ColumnHeader_RoutineSteps.Text = "Steps"
		'
		'Button_AddRoutine
		'
		Me.Button_AddRoutine.Location = New System.Drawing.Point(158, 387)
		Me.Button_AddRoutine.Name = "Button_AddRoutine"
		Me.Button_AddRoutine.Size = New System.Drawing.Size(142, 30)
		Me.Button_AddRoutine.TabIndex = 23
		Me.Button_AddRoutine.Text = "Add Routine"
		Me.Button_AddRoutine.UseVisualStyleBackColor = True
		'
		'GroupBox_StepDetails
		'
		Me.GroupBox_StepDetails.Controls.Add(Me.Button_StepIndexDown)
		Me.GroupBox_StepDetails.Controls.Add(Me.Label_StepName)
		Me.GroupBox_StepDetails.Controls.Add(Me.TextBox_StepName)
		Me.GroupBox_StepDetails.Controls.Add(Me.Label_StepDescription)
		Me.GroupBox_StepDetails.Controls.Add(Me.TextBox_StepDescription)
		Me.GroupBox_StepDetails.Controls.Add(Me.Button_StepIndexUp)
		Me.GroupBox_StepDetails.Location = New System.Drawing.Point(541, 280)
		Me.GroupBox_StepDetails.Name = "GroupBox_StepDetails"
		Me.GroupBox_StepDetails.Size = New System.Drawing.Size(288, 173)
		Me.GroupBox_StepDetails.TabIndex = 24
		Me.GroupBox_StepDetails.TabStop = False
		Me.GroupBox_StepDetails.Text = "Step Details"
		'
		'GroupBox_RoutineDetails
		'
		Me.GroupBox_RoutineDetails.Controls.Add(Me.TextBox_RoutineDescription)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.Label2)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.TextBox_RoutineName)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.Label1)
		Me.GroupBox_RoutineDetails.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox_RoutineDetails.Name = "GroupBox_RoutineDetails"
		Me.GroupBox_RoutineDetails.Size = New System.Drawing.Size(288, 174)
		Me.GroupBox_RoutineDetails.TabIndex = 25
		Me.GroupBox_RoutineDetails.TabStop = False
		Me.GroupBox_RoutineDetails.Text = "Routine Details"
		'
		'TextBox_RoutineDescription
		'
		Me.TextBox_RoutineDescription.AcceptsReturn = True
		Me.TextBox_RoutineDescription.AcceptsTab = True
		Me.TextBox_RoutineDescription.Location = New System.Drawing.Point(90, 48)
		Me.TextBox_RoutineDescription.Multiline = True
		Me.TextBox_RoutineDescription.Name = "TextBox_RoutineDescription"
		Me.TextBox_RoutineDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox_RoutineDescription.Size = New System.Drawing.Size(192, 120)
		Me.TextBox_RoutineDescription.TabIndex = 27
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(21, 51)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 13)
		Me.Label2.TabIndex = 26
		Me.Label2.Text = "Description:"
		'
		'TextBox_RoutineName
		'
		Me.TextBox_RoutineName.Location = New System.Drawing.Point(90, 22)
		Me.TextBox_RoutineName.Name = "TextBox_RoutineName"
		Me.TextBox_RoutineName.Size = New System.Drawing.Size(192, 20)
		Me.TextBox_RoutineName.TabIndex = 26
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 25)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(78, 13)
		Me.Label1.TabIndex = 26
		Me.Label1.Text = "Routine Name:"
		'
		'Button_StepsUpdateChanges
		'
		Me.Button_StepsUpdateChanges.Location = New System.Drawing.Point(343, 387)
		Me.Button_StepsUpdateChanges.Name = "Button_StepsUpdateChanges"
		Me.Button_StepsUpdateChanges.Size = New System.Drawing.Size(192, 30)
		Me.Button_StepsUpdateChanges.TabIndex = 26
		Me.Button_StepsUpdateChanges.Text = "Update Changes"
		Me.Button_StepsUpdateChanges.UseVisualStyleBackColor = True
		'
		'Button_ShowSteps
		'
		Me.Button_ShowSteps.Location = New System.Drawing.Point(306, 27)
		Me.Button_ShowSteps.Name = "Button_ShowSteps"
		Me.Button_ShowSteps.Size = New System.Drawing.Size(31, 426)
		Me.Button_ShowSteps.TabIndex = 27
		Me.Button_ShowSteps.Text = "-->"
		Me.Button_ShowSteps.UseVisualStyleBackColor = True
		'
		'ButtonLoadRoutine
		'
		Me.ButtonLoadRoutine.Location = New System.Drawing.Point(12, 387)
		Me.ButtonLoadRoutine.Name = "ButtonLoadRoutine"
		Me.ButtonLoadRoutine.Size = New System.Drawing.Size(142, 30)
		Me.ButtonLoadRoutine.TabIndex = 28
		Me.ButtonLoadRoutine.Text = "Insert Routine From File..."
		Me.ButtonLoadRoutine.UseVisualStyleBackColor = True
		'
		'Button_RoutineUpdateChanges
		'
		Me.Button_RoutineUpdateChanges.Location = New System.Drawing.Point(12, 423)
		Me.Button_RoutineUpdateChanges.Name = "Button_RoutineUpdateChanges"
		Me.Button_RoutineUpdateChanges.Size = New System.Drawing.Size(288, 30)
		Me.Button_RoutineUpdateChanges.TabIndex = 29
		Me.Button_RoutineUpdateChanges.Text = "Update Changes"
		Me.Button_RoutineUpdateChanges.UseVisualStyleBackColor = True
		'
		'Button_StepIndexUp
		'
		Me.Button_StepIndexUp.BackgroundImage = Global.MOCVD_Recipe_Editor.My.Resources.Resources.UpArrow
		Me.Button_StepIndexUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button_StepIndexUp.Location = New System.Drawing.Point(6, 76)
		Me.Button_StepIndexUp.Name = "Button_StepIndexUp"
		Me.Button_StepIndexUp.Size = New System.Drawing.Size(25, 25)
		Me.Button_StepIndexUp.TabIndex = 30
		Me.Button_StepIndexUp.UseVisualStyleBackColor = True
		'
		'Button_StepIndexDown
		'
		Me.Button_StepIndexDown.BackgroundImage = Global.MOCVD_Recipe_Editor.My.Resources.Resources.DownArrow
		Me.Button_StepIndexDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button_StepIndexDown.Location = New System.Drawing.Point(6, 107)
		Me.Button_StepIndexDown.Name = "Button_StepIndexDown"
		Me.Button_StepIndexDown.Size = New System.Drawing.Size(25, 25)
		Me.Button_StepIndexDown.TabIndex = 30
		Me.Button_StepIndexDown.UseVisualStyleBackColor = True
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1134, 459)
		Me.Controls.Add(Me.Button_RoutineUpdateChanges)
		Me.Controls.Add(Me.ButtonLoadRoutine)
		Me.Controls.Add(Me.Button_ShowSteps)
		Me.Controls.Add(Me.Button_StepsUpdateChanges)
		Me.Controls.Add(Me.GroupBox_RoutineDetails)
		Me.Controls.Add(Me.GroupBox_StepDetails)
		Me.Controls.Add(Me.Button_AddRoutine)
		Me.Controls.Add(Me.ListView_Routines)
		Me.Controls.Add(Me.GroupBox_MFCs)
		Me.Controls.Add(Me.ListView_Steps)
		Me.Controls.Add(Me.GroupBoxTiming)
		Me.Controls.Add(Me.GroupBoxValves)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.Button_AddStep)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "FormMain"
		Me.Text = "MOCVD Recipe Editor"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.NumericUpDown_Time, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDown_Ramp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxValves.ResumeLayout(False)
		Me.GroupBoxValves.PerformLayout()
		Me.ContextMenuStrip_ValveList.ResumeLayout(False)
		CType(Me.NumericUpDownValveIndex, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxTiming.ResumeLayout(False)
		Me.GroupBoxTiming.PerformLayout()
		CType(Me.DataSocketServer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox_MFCs.ResumeLayout(False)
		Me.GroupBox_MFCs.PerformLayout()
		CType(Me.NumericUpDown_MFCsSetPoint, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDown_MFCsIndex, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox_StepDetails.ResumeLayout(False)
		Me.GroupBox_StepDetails.PerformLayout()
		Me.GroupBox_RoutineDetails.ResumeLayout(False)
		Me.GroupBox_RoutineDetails.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NumericUpDown_Time As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label_Time As System.Windows.Forms.Label
	Friend WithEvents Label_Ramp As System.Windows.Forms.Label
	Friend WithEvents Label_Delay As System.Windows.Forms.Label
	Friend WithEvents NumericUpDown_Ramp As System.Windows.Forms.NumericUpDown
	Friend WithEvents NumericUpDown_Delay As System.Windows.Forms.NumericUpDown
	Friend WithEvents ComboBox_TimeUnits As System.Windows.Forms.ComboBox
	Friend WithEvents ComboBox_RampUnits As System.Windows.Forms.ComboBox
	Friend WithEvents ComboBox_DelayUnits As System.Windows.Forms.ComboBox
	Friend WithEvents Button_AddStep As System.Windows.Forms.Button
	Friend WithEvents GroupBoxValves As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBoxTiming As System.Windows.Forms.GroupBox
	Friend WithEvents NumericUpDownValveIndex As System.Windows.Forms.NumericUpDown
	Friend WithEvents RadioButton_ValveClose As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton_ValveOpen As System.Windows.Forms.RadioButton
	Friend WithEvents LabelValveIndex As System.Windows.Forms.Label
	Friend WithEvents Button_AddValve As System.Windows.Forms.Button
	Friend WithEvents ListView_ValveList As System.Windows.Forms.ListView
	Friend WithEvents ListView_Steps As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeaderValve As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeaderAction As System.Windows.Forms.ColumnHeader
	Friend WithEvents ContextMenuStrip_ValveList As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents SetToCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RemoveItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SetToOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents DataSocketServer1 As NationalInstruments.Net.DataSocketServer
	Friend WithEvents GroupBox_MFCs As System.Windows.Forms.GroupBox
	Friend WithEvents ListView_MFCsList As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader_MFC As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_SetPoint As System.Windows.Forms.ColumnHeader
	Friend WithEvents Button_MFCs As System.Windows.Forms.Button
	Friend WithEvents Label_MFCsSetPoint As System.Windows.Forms.Label
	Friend WithEvents NumericUpDown_MFCsSetPoint As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label_MFCsIndex As System.Windows.Forms.Label
	Friend WithEvents NumericUpDown_MFCsIndex As System.Windows.Forms.NumericUpDown
	Friend WithEvents TextBox_StepName As System.Windows.Forms.TextBox
	Friend WithEvents Label_StepName As System.Windows.Forms.Label
	Friend WithEvents Label_StepDescription As System.Windows.Forms.Label
	Friend WithEvents TextBox_StepDescription As System.Windows.Forms.TextBox
	Friend WithEvents ColumnHeader_StepIndex As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepName As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepDescription As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepTime As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepRamp As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepDelay As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepValves As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepMFCs As System.Windows.Forms.ColumnHeader
	Friend WithEvents ListView_Routines As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader_RoutineIndex As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_RoutineName As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_RoutineDescription As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_RoutineSteps As System.Windows.Forms.ColumnHeader
	Friend WithEvents Button_AddRoutine As System.Windows.Forms.Button
	Friend WithEvents GroupBox_StepDetails As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBox_RoutineDetails As System.Windows.Forms.GroupBox
	Friend WithEvents TextBox_RoutineDescription As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents TextBox_RoutineName As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Button_StepsUpdateChanges As System.Windows.Forms.Button
	Friend WithEvents Button_ShowSteps As System.Windows.Forms.Button
	Friend WithEvents ButtonLoadRoutine As System.Windows.Forms.Button
	Friend WithEvents Button_RoutineUpdateChanges As System.Windows.Forms.Button
	Friend WithEvents Button_StepIndexUp As System.Windows.Forms.Button
	Friend WithEvents Button_StepIndexDown As System.Windows.Forms.Button

End Class