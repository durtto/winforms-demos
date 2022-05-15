#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Syncfusion.WinForms.Controls;
using System.Collections.Generic;
using Syncfusion.WinForms.ListView.Enums;
using System.IO;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace Localization
{
    partial class Form1 : SfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
               components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "File");
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "EditMenu");
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.undoPopup = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.undoLabel = new System.Windows.Forms.Label();
            this.undoList = new Syncfusion.Windows.Forms.FocuslessListBox();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.staticBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem();
            this.comboBoxBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.TextBoxBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.undoPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barItem14
            // 
            this.barItem14.BarName = "barItem14";
            this.barItem14.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.barItem14.ID = "Errors";
            this.barItem14.ShowToolTipInPopUp = false;
            this.barItem14.SizeToFit = true;
            this.barItem14.Text = "从输出查看:";
            // 
            // barItem15
            // 
            this.barItem15.BarName = "barItem15";
            this.barItem15.ShowToolTipInPopUp = false;
            this.barItem15.SizeToFit = true;
            // 
            // barItem16
            // 
            this.barItem16.BarName = "barItem16";
            this.barItem16.ShowToolTipInPopUp = false;
            this.barItem16.SizeToFit = true;
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.AutoLoadToolBarPositions = false;
            this.mainFrameBarManager1.AutoPersistCustomization = false;
#if !NETCORE
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
#endif
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("EditMenu");
            this.mainFrameBarManager1.Categories.Add("Icons");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.WinForms.Controls.SfForm";
            this.mainFrameBarManager1.EnableMenuMerge = true;
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem9,
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.dropDownBarItem,
            this.barItem21,
            this.barItem22,
            this.barItem23,
            this.barItem24,
            this.staticBarItem,
            this.comboBoxBarItem,
            this.TextBoxBarItem});
            this.mainFrameBarManager1.MetroBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.UseBackwardCompatiblity = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "File";
            this.bar1.Caption = "File";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.barItem1.ID = "&FILE";
            this.barItem1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "和文件";
            this.barItem1.WrapLength = 20;
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.CategoryIndex = 0;
            this.barItem2.ID = "EDIT";
            this.barItem2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            this.barItem2.Text = "编者";
            this.barItem2.WrapLength = 20;
            // 
            // bar2
            // 
            this.bar2.BarName = "编辑菜单"; //EditMenu
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.dropDownBarItem,
            this.barItem21,
            this.barItem22,
            this.barItem23,
            this.barItem24,
            this.staticBarItem,
            this.comboBoxBarItem,
            this.TextBoxBarItem});
            this.bar2.Manager = this.mainFrameBarManager1;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            3,
            5,
            8});
            // 
            // barItem17
            // 
            this.barItem17.BarName = "barItem17";
            this.barItem17.ID = "Open File(Ctrl+O)";
            this.barItem17.ImageIndex = 12;
            this.barItem17.ImageList = this.imageList2;
            this.barItem17.ShowToolTipInPopUp = false;
            this.barItem17.SizeToFit = true;
            this.barItem17.Text = "打开文件";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Open-file.png");
            this.imageList2.Images.SetKeyName(1, "save.jpg");
            this.imageList2.Images.SetKeyName(2, "save-all.png");
            this.imageList2.Images.SetKeyName(3, "undo-6.png");
            this.imageList2.Images.SetKeyName(4, "REDO1.png");
            this.imageList2.Images.SetKeyName(5, "cut.png");
            this.imageList2.Images.SetKeyName(6, "copy.png");
            this.imageList2.Images.SetKeyName(7, "paste.png");
            this.imageList2.Images.SetKeyName(8, "open-512.png");
            this.imageList2.Images.SetKeyName(9, "save-as.png");
            this.imageList2.Images.SetKeyName(10, "copy2.png");
            this.imageList2.Images.SetKeyName(11, "Paste (1).png");
            this.imageList2.Images.SetKeyName(12, "Open32.png");
            this.imageList2.Images.SetKeyName(13, "Save32.png");
            this.imageList2.Images.SetKeyName(14, "SaveAs32.png");
            this.imageList2.Images.SetKeyName(15, "Undo_Big.ico");
            this.imageList2.Images.SetKeyName(16, "Redo_Big.ico");
            this.imageList2.Images.SetKeyName(17, "Cut16.png");
            this.imageList2.Images.SetKeyName(18, "Copy16.png");
            this.imageList2.Images.SetKeyName(19, "Paste32.png");
            // 
            // barItem18
            // 
            this.barItem18.BarName = "barItem18";
            this.barItem18.ID = "Save File";
            this.barItem18.ImageIndex = 13;
            this.barItem18.ImageList = this.imageList2;
            this.barItem18.ShowToolTipInPopUp = false;
            this.barItem18.SizeToFit = true;
            this.barItem18.Text = "保存文件";
            // 
            // barItem19
            // 
            this.barItem19.BarName = "barItem19";
            this.barItem19.ID = "SaveAs";
            this.barItem19.ImageIndex = 14;
            this.barItem19.ImageList = this.imageList2;
            this.barItem19.ShowToolTipInPopUp = false;
            this.barItem19.SizeToFit = true;
            this.barItem19.Text = "另存为";
            // 
            // dropDownBarItem
            // 
            this.dropDownBarItem.BarName = "dropDownBarItem";
            this.dropDownBarItem.ID = "Undo";
            this.dropDownBarItem.ImageIndex = 15;
            this.dropDownBarItem.ImageList = this.imageList2;
            this.dropDownBarItem.PopupControlContainer = this.undoPopup;
            this.dropDownBarItem.ShowToolTipInPopUp = false;
            this.dropDownBarItem.SizeToFit = true;
            this.dropDownBarItem.Text = "颚";
            // 
            // undoPopup
            // 
            this.undoPopup.BackColor = System.Drawing.SystemColors.Window;
            this.undoPopup.Controls.Add(this.undoLabel);
            this.undoPopup.Controls.Add(this.undoList);
            this.undoPopup.Location = new System.Drawing.Point(24, 24);
            this.undoPopup.Name = "undoPopup";
            this.undoPopup.Padding = new System.Windows.Forms.Padding(1);
            this.undoPopup.Size = new System.Drawing.Size(96, 195);
            this.undoPopup.TabIndex = 6;
            this.undoPopup.Visible = false;
            this.undoPopup.CloseUp += new Syncfusion.Windows.Forms.PopupClosedEventHandler(this.undoPopup_CloseUp);
            this.undoPopup.BeforePopup += new System.ComponentModel.CancelEventHandler(this.undoPopup_BeforePopup);
            // 
            // undoLabel
            // 
            this.undoLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.undoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.undoLabel.Location = new System.Drawing.Point(1, 175);
            this.undoLabel.Name = "undoLabel";
            this.undoLabel.Size = new System.Drawing.Size(96, 20);
            this.undoLabel.TabIndex = 1;
            this.undoLabel.Text = "颚";
            this.undoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.undoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.undoLabel_MouseDown);
            // 
            // undoList
            // 
            this.undoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.undoList.CausesValidation = false;
            this.undoList.Dock = System.Windows.Forms.DockStyle.Top;
            this.undoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoList.ItemHeight = 20;
            this.undoList.Items.AddRange(new object[] {
            "一",
            "两",
            "三",
            "四",
            "五",
            "六",
            "七",
            "八",
            "九",
            "十",
            "一个10",
            "十二",
            "十三"});
            this.undoList.Location = new System.Drawing.Point(1, 1);
            this.undoList.Name = "undoList";
            this.undoList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.undoList.Size = new System.Drawing.Size(154, 120);
            this.undoList.TabIndex = 0;
            this.undoList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseDown);
            this.undoList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseMove);
            this.undoList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.undoList_MouseUp);
            // 
            // barItem21
            // 
            this.barItem21.BarName = "barItem21";
            this.barItem21.ID = "Redo";
            this.barItem21.ImageIndex = 16;
            this.barItem21.ImageList = this.imageList2;
            this.barItem21.ShowToolTipInPopUp = false;
            this.barItem21.SizeToFit = true;
            this.barItem21.Text = "ف再次";
            // 
            // barItem22
            // 
            this.barItem22.BarName = "barItem22";
            this.barItem22.ID = "cut";
            this.barItem22.ImageIndex = 17;
            this.barItem22.ImageList = this.imageList2;
            this.barItem22.ShowToolTipInPopUp = false;
            this.barItem22.SizeToFit = true;
            this.barItem22.Text = "ف再次";
            // 
            // barItem23
            // 
            this.barItem23.BarName = "barItem23";
            this.barItem23.ID = "copy";
            this.barItem23.ImageIndex = 18;
            this.barItem23.ImageList = this.imageList2;
            this.barItem23.ShowToolTipInPopUp = false;
            this.barItem23.SizeToFit = true;
            this.barItem23.Text = "ف再次";
            // 
            // barItem24
            // 
            this.barItem24.BarName = "barItem24";
            this.barItem24.ID = "paste";
            this.barItem24.ImageIndex = 11;
            this.barItem24.ImageList = this.imageList2;
            this.barItem24.ShowToolTipInPopUp = false;
            this.barItem24.SizeToFit = true;
            this.barItem24.Text = "ف再次";
            // 
            // staticBarItem
            // 
            this.staticBarItem.BarName = "staticBarItem";
            this.staticBarItem.ID = "Launch";
            this.staticBarItem.ShowToolTipInPopUp = false;
            this.staticBarItem.SizeToFit = true;
            this.staticBarItem.Text = "开放和开放";
            // 
            // comboBoxBarItem
            // 
            this.comboBoxBarItem.BarName = "comboBoxBarItem";
            this.comboBoxBarItem.ChoiceList.AddRange(new string[] {
            "更正",
            "发布",
            "游"});
            this.comboBoxBarItem.ID = "Debug";
            this.comboBoxBarItem.ShowToolTipInPopUp = false;
            this.comboBoxBarItem.MinWidth = 55;
            this.comboBoxBarItem.Text = "二合一";
            this.comboBoxBarItem.TextBoxValue = "寻找";
            // 
            // TextBoxBarItem
            // 
            this.TextBoxBarItem.BarName = "TextBoxBarItem";
            this.TextBoxBarItem.ID = "TextBox";
            this.TextBoxBarItem.ShowToolTipInPopUp = false;
            this.TextBoxBarItem.MinWidth = 55;
            this.TextBoxBarItem.Text = "مربع نص";
            this.TextBoxBarItem.TextBoxValue = "去";
            this.TextBoxBarItem.Value = "去";
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.ID = "_1";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            // 
            // barItem4
            // 
            this.barItem4.BarName = "barItem4";
            this.barItem4.CategoryIndex = 0;
            this.barItem4.ID = "WINDOW";
            this.barItem4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.barItem4.ShowToolTipInPopUp = false;
            this.barItem4.SizeToFit = true;
            this.barItem4.Text = "窗口";
            this.barItem4.WrapLength = 20;
            // 
            // barItem5
            // 
            this.barItem5.BarName = "barItem5";
            this.barItem5.ID = "_2";
            this.barItem5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.barItem5.ShowToolTipInPopUp = false;
            this.barItem5.SizeToFit = true;
            this.barItem5.WrapLength = 20;
            // 
            // barItem9
            // 
            this.barItem9.BarName = "barItem9";
            this.barItem9.CategoryIndex = 1;
            this.barItem9.ID = "Save All";
            this.barItem9.ShowToolTipInPopUp = false;
            this.barItem9.SizeToFit = true;
            this.barItem9.Text = "全部保存";
            // 
            // barItem7
            // 
            this.barItem7.BarName = "barItem7";
            this.barItem7.ShowToolTipInPopUp = false;
            this.barItem7.SizeToFit = true;
            // 
            // barItem8
            // 
            this.barItem8.BarName = "barItem8";
            this.barItem8.CategoryIndex = 1;
            this.barItem8.ID = "Save";
            this.barItem8.ShowToolTipInPopUp = false;
            this.barItem8.SizeToFit = true;
            this.barItem8.Text = "发布";
            // 
            // barItem10
            // 
            this.barItem10.BarName = "barItem10";
            this.barItem10.ShowToolTipInPopUp = false;
            this.barItem10.SizeToFit = true;
            // 
            // editControl1
            // 
            this.editControl1.AllowZoom = false;
            this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.editControl1.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.editControl1.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.editControl1.Configurator = config1;
            this.editControl1.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editControl1.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.editControl1.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.editControl1.ContextPromptBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.editControl1.ContextTooltipBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(236))))));
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.IndentationBlockBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(61)))), ((int)(((byte)(139))))));
            this.editControl1.IndentationBlockBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.editControl1.IndentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editControl1.IndicatorMarginBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.editControl1.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 34);
            this.editControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editControl1.MarkChangedLines = true;
            this.editControl1.MarkerAreaWidth = 24;
            this.editControl1.Name = "editControl1";
            this.editControl1.RenderRightToLeft = false;
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 289);
            this.editControl1.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            this.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.editControl1.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(1264, 1033);
            this.editControl1.StatusBarSettings.CoordsPanel.Width = 224;
            this.editControl1.StatusBarSettings.EncodingPanel.Width = 149;
            this.editControl1.StatusBarSettings.FileNamePanel.Width = 149;
            this.editControl1.StatusBarSettings.InsertPanel.Width = 48;
            this.editControl1.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.editControl1.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.editControl1.StatusBarSettings.StatusPanel.Width = 104;
            this.editControl1.StatusBarSettings.TextPanel.Width = 320;
            this.editControl1.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Office2016Colorful;
            this.editControl1.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Colorful;
            this.editControl1.TabIndex = 20;
            this.editControl1.Text = "editControl1\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            this.editControl1.UseXPStyle = false;
            this.editControl1.UseXPStyleBorder = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.editControl1.ZoomFactor = 1F;
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.AllowDropDownResize = false;
            this.sfComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            List<string> programmingLanguages = new List<string>();
            programmingLanguages.Add("CSharp");
            programmingLanguages.Add("PowerShell");
            programmingLanguages.Add("HTML");
            programmingLanguages.Add("XML");
            programmingLanguages.Add("PASCAL");
            programmingLanguages.Add("HTML with Embeded JavaScript");
            programmingLanguages.Add("HTML with VBScript");
            programmingLanguages.Add("Delphi");
            programmingLanguages.Add("SQL");
            programmingLanguages.Add("Java");
            programmingLanguages.Add("VB.Net");
            programmingLanguages.Add("VBScript");
            programmingLanguages.Add("JScript");
            this.sfComboBox1.DataSource = programmingLanguages;
            this.sfComboBox1.Location = new System.Drawing.Point(950, 5);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(121, 29);
            this.sfComboBox1.DropDownListView.Height = 200;
            this.sfComboBox1.TabIndex = 21;
            this.sfComboBox1.Text = "CSharp";
            this.sfComboBox1.SelectedIndexChanged += SfComboBox1_SelectedIndexChanged;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1264, 1067);
            this.Controls.Add(this.sfComboBox1);
            this.Controls.Add(this.editControl1);
            this.Load += new EventHandler(Form1_Load);
            this.SizeChanged += Form1_SizeChanged1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.WindowState = FormWindowState.Maximized;
            this.ShowIcon = false;
            this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Text = "ا光纤";
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.undoPopup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Save;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAs;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAsHTML;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SaveAsRTF;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Print;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem PrintPriview;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Exit;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem undo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redo;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cut;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copy;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pasteSpecial;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Delete;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem SelectAll;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem FindandReplace;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem find;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem replace;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Goto;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Advanced;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem WordWrap;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tabify;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Untabify;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem IncreaseLineIndent;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem DecreaseLineIndent;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Bookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Tooglebookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Nextbookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Previousbookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Clearbookmark;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Wrapping;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Enable;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Disable;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem WrapType;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Word;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Character;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Splitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem EditControlStyle;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem Background;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer2;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer3;
        private ColorPickerUIAdv colorPickerUIAdv1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem VerticalSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem NoSplits;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem HorizontalSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem QuarantSplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem ShowVertical;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem horizontalsplitter;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2019Colorful;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem HighContrastBlack;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016Colorful;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016White;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016DarkGray;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem Office2016Black;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem RightToLefts;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem viewItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem debugItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem Search;
        public Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem22;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem23;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem24;
        private Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem staticBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem TextBoxBarItem;
        private Syncfusion.Windows.Forms.PopupControlContainer undoPopup;
        private Syncfusion.Windows.Forms.FocuslessListBox undoList;
        private System.Windows.Forms.Label undoLabel;
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private ImageList imageList2;
    }
}

