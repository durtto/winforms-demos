#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartStyles
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette
            chart.Skins = Skins.Metro;
            #endregion

            #region Chart Appearance Customization


            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
         
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;         
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes and Legend Customization

            chart.PrimaryXAxis.HidePartialLabels = true;           
           
            chart.PrimaryYAxis.Title = "Sales Volume(Million $)";
            chart.Text = "Sales Volume Comparison";
            chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;                   
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.ItemsSize = new Size(15, 15);
            #endregion
        }
    }
}
