#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Syncfusion.Windows.Forms.Diagram;
using System.IO;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Imaging;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms;

namespace FloorPlan_Diagram
{
    public partial class Form1 : Form
    {
        #region Members

        bool needSave = false;
        public string fileName;

        #endregion

        #region Form initialize
        public Form1()
        {
            InitializeComponent();
            //this.diagram1.BeginUpdate();
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.HorizontalRuler.BackgroundColor = Color.White;
            this.diagram1.VerticalRuler.BackgroundColor = Color.White;
#if !NETCORE
            diagram1.LoadBinary(@"..\..\..\..\..\..\common\Data\Diagram\edd\FloorPlan.edd");
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\common\Data\Diagram\edp\FloorPlan Shapes.edp");
#else
            diagram1.LoadBinary(@"..\..\..\..\..\..\..\common\Data\Diagram\edd\FloorPlan.edd");
            paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\common\Data\Diagram\edp\FloorPlan Shapes.edp");
#endif
            GroupBarAppearance();
            //this.diagram1.EndUpdate();

            // Wire up OnIdle processing
            Application.Idle += new EventHandler(Application_Idle);
        }

#endregion

#region Private Methods
        /// <summary>
        /// Change's the appearance of GroupBar
        /// </summary>
        private void GroupBarAppearance()
        {
            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = (int)DpiAware.LogicalToDeviceUnits(80);
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.FlatLook = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }           
        }

        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {            
            this.diagram1.View.Grid.GridStyle = GridStyle.Line;
            this.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram1.View.Grid.Color = Color.LightGray;
            this.diagram1.View.Grid.VerticalSpacing = 15;
            this.diagram1.View.Grid.HorizontalSpacing = 15;
            this.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;                                   
            this.diagram1.View.SelectionList.Clear();
        }
#endregion

#region Properties

        public bool SaveChanges
        {
            get
            {
                if (diagram1.Model.Modified || needSave)
                    return true;
                else
                    return false;
            }
            set
            {
                needSave = value;
            }
        }

        public bool HasFileName
        {
            get
            {
                return (this.fileName != null && this.fileName.Length > 0);
            }
        }

#endregion

#region Event Handlers

        void Application_Idle(object sender, EventArgs e)
        {            
            this.saveToolStripButton.Enabled = true;
            this.saveAsToolStripButton.Enabled = true;
            this.cutToolStripButton.Enabled = diagram1.CanCut;
            this.copyToolStripButton.Enabled = diagram1.CanCopy;
            if (this.WindowState != FormWindowState.Minimized)
                this.pasteToolStripButton.Enabled = diagram1.CanPaste;
            this.undoToolStripButton.Enabled = diagram1.Model.HistoryManager.CanUndo;
            this.redoToolStripButton.Enabled = diagram1.Model.HistoryManager.CanRedo;
            this.deleteToolStripButton.Enabled = (this.diagram1.View.SelectionList.Count > 0);           
        }

#region MenuTools

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.HasFileName)
                    {
                        this.saveFileDialog1.FileName = this.fileName;
                    }
                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                        diagram1.Model.Clear();
                        Model model = new Model();
                        model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        model.LineStyle.LineColor = Color.LightGray;
                        diagram1.Model = model;
                    }
                }
                else if (res == DialogResult.No)
                {
                    diagram1.Model.Clear();
                    Model model = new Model();
                    model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    model.LineStyle.LineColor = Color.LightGray;
                    diagram1.Model = model;
                }
            }
            else
            {
                diagram1.Model.Clear();
                Model model = new Model();
                model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                model.LineStyle.LineColor = Color.LightGray;
                diagram1.Model = model;
            }
            this.fileName = "";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                    }

                    this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    this.openFileDialog1.Title = "Open Diagram";
                    this.openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                        }
                    }
                }
                else if (res == DialogResult.No)
                {
                    this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    this.openFileDialog1.Title = "Open Diagram";
                    this.openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                        }
                    }
                }
            }
            else
            {
                this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                this.openFileDialog1.Title = "Open Diagram";
                this.openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                    }
                }
            }
            this.fileName = openFileDialog1.FileName;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName))
            {
                saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            diagram1.SaveBinary(saveFileDialog1.FileName);
                            break;
                        case 2:
#if !NETCORE
                            diagram1.SaveSoap(saveFileDialog1.FileName);
#endif
                            break;
                    }
                    this.fileName = saveFileDialog1.FileName;
                }
            }
            else
            {
                FileInfo fi = new FileInfo(fileName);
                if (fi.Extension == ".edd")
                {
                    diagram1.SaveBinary(fi.FullName);
                }
                else if (fi.Extension == ".xml")
                {
#if !NETCORE
                    diagram1.SaveSoap(fi.FullName);
#endif
                }
            }
        }

        private void undoToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Undo();
        }

        private void redoToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Redo();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Cut();
            this.pasteToolStripButton.Enabled = true;
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Copy();
            this.pasteToolStripButton.Enabled = true;
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Paste();
            this.pasteToolStripButton.Enabled = false;
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Model.BeginUpdate();
            diagram1.Controller.Delete();
            diagram1.Model.EndUpdate();

        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomOut();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram1.View.ZoomToActual();
        }

        
        private void pageSettingsToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram1 != null && this.diagram1.Model != null)
            {
                Syncfusion.Windows.Forms.Diagram.PageSetupDialog dlgPrintSetup = new Syncfusion.Windows.Forms.Diagram.PageSetupDialog(this.diagram1.View);

                // Made to make values more user friendly 
                dlgPrintSetup.PrintSettings = this.diagram1.View.PageSettings;
                dlgPrintSetup.PrintZoom = this.diagram1.View.PrintZoom;

                if (dlgPrintSetup.ShowDialog() == DialogResult.OK)
                {
                    this.diagram1.View.PageSettings = dlgPrintSetup.PrintSettings;
                    this.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom;
                    this.diagram1.View.RefreshPageSettings();
                }
            }
        }

        private void previewToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram1 != null)
            {
                PrintDocument printDoc = this.diagram1.CreatePrintDocument();
                PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog();

                printDoc.PrinterSettings.FromPage = 0;
                printDoc.PrinterSettings.ToPage = 0;
                printDoc.PrinterSettings.PrintRange = PrintRange.AllPages;

                printPreviewDlg.Document = printDoc;
                printPreviewDlg.ShowDialog(this);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram1 != null)
            {
                PrintDocument printDoc = this.diagram1.CreatePrintDocument();
                PrintDialog printDlg = new PrintDialog();
                printDlg.Document = printDoc;

                printDlg.AllowSomePages = true;

                if (printDlg.ShowDialog(this) == DialogResult.OK)
                {
                    printDoc.PrinterSettings = printDlg.PrinterSettings;
                    printDoc.Print();
                }
            }
        }

        private void showGridToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.diagram1.View.Grid.Visible)
                this.diagram1.View.Grid.Visible = false;
            else
                this.diagram1.View.Grid.Visible = true;
        }

        private void snapToGridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (diagram1.View.Grid.SnapToGrid)
                diagram1.View.Grid.SnapToGrid = false;
            else
                diagram1.View.Grid.SnapToGrid = true;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://help.syncfusion.com/";
            System.Diagnostics.Process.Start(targetURL);
        }

       
        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "Diagram";
            saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
            saveFileDialog1.Title = "Save File As:";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        diagram1.SaveBinary(saveFileDialog1.FileName);
                        break;
                    case 2:
#if !NETCORE
                        diagram1.SaveSoap(saveFileDialog1.FileName);
#endif
                        break;
                    default:
                        diagram1.SaveBinary(saveFileDialog1.FileName);
                        break;
                }
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"W3C Portable Network Graphics(*.png)|*.png";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Png;
                SaveImage(saveFileDialog1.FileName, imgformat);
            }
            else
            {
                return;
            }
        }

        private void jPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Joint Photographic Experts Group(*.jpeg)|*.jpeg";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Jpeg;
                SaveImage(saveFileDialog1.FileName, imgformat);
            }
            else
            {
                return;
            }
        }

        private void gIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Graphics Interchange Format(*.gif)|*.gif";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Gif;
                SaveImage(saveFileDialog1.FileName, imgformat);

            }
            else
            {
                return;
            }
        }

        private void sVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = @"Scalable Vector Graphics Format(*.svg)|*.svg";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ToSvg tosvg = new ToSvg();
                // Get Diagram Nodes Bounding Rectangle.
                RectangleF rectBounding = this.diagram1.Model.GetBoundingRect();
                Graphics gfx = tosvg.GetRealGraphics(new Size((int)rectBounding.Width, (int)rectBounding.Height));
                this.diagram1.ExportDiagramToGraphics(gfx);
                tosvg.Save(saveFileDialog1.FileName);

            }
            else
            {
                return;
            }
        }

        private void rulerToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram1.ShowRulers = !this.diagram1.ShowRulers;
            rulerToolStripButton.Checked = !rulerToolStripButton.Checked;
        }

#endregion

#endregion

#region Helper Methods
        /// <summary>
        /// Save diagram as Image
        /// </summary>
        /// <param name="filename">Filename </param>
        /// <param name="imageformat">image format</param>
        private void SaveImage(string filename, ImageFormat imageformat)
        {
            Image img = this.diagram1.View.ExportDiagramAsImage(false);
            img.Save(filename, imageformat);
        }

        /// <summary>
        /// Save diagram
        /// </summary>
        /// <param name="filename">file name</param>
        /// <param name="index">index</param>
        private void SaveDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
                    diagram1.SaveBinary(filename);
                    break;
                case 2:
#if !NETCORE
                    diagram1.SaveSoap(filename);
#endif
                    break;
                default:
                    diagram1.SaveBinary(filename);
                    break;
            }
        }

        /// <summary>
        /// Open Diagram
        /// </summary>
        /// <param name="filename">file name</param>
        /// <param name="index">index</param>
        private void OpenDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
                    diagram1.LoadBinary(filename);
                    break;
                case 2:
#if !NETCORE
                    diagram1.LoadSoap(filename);
#endif
                    break;
                default:
                    diagram1.LoadBinary(filename);
                    break;
            }
        }
#endregion

        private void panToolStripButton_Click(object sender, EventArgs e)
        {
            diagram1.Controller.ActivateTool("PanTool");
        }  
    }
}

