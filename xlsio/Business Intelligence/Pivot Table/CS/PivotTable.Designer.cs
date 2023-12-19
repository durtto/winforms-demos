#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace EssentialXlsIOSamples
{
    partial class PivotTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotTable));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel2013 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2010 = new System.Windows.Forms.RadioButton();
            this.rdbExcel2007 = new System.Windows.Forms.RadioButton();
            this.btnCustomize = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbColumnFieldFilter = new System.Windows.Forms.CheckBox();
            this.ckbRowFieldFilter = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.multipleFilter = new System.Windows.Forms.RadioButton();
            this.rdbRCValueFilter = new System.Windows.Forms.RadioButton();
            this.rdbRCLabelFilter = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbMultiplePageFilter = new System.Windows.Forms.CheckBox();
            this.ckbPageFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ckbApplyGrouping = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 48);
            this.label2.TabIndex = 72;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(131, 294);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(137, 26);
            this.btnCreate.TabIndex = 70;
            this.btnCreate.Text = "Create Pivot Table";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExcel2013);
            this.groupBox1.Controls.Add(this.rdbExcel2010);
            this.groupBox1.Controls.Add(this.rdbExcel2007);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(131, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 35);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SaveAs";
            // 
            // rdbExcel2013
            // 
            this.rdbExcel2013.AutoSize = true;
            this.rdbExcel2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2013.Location = new System.Drawing.Point(188, 11);
            this.rdbExcel2013.Name = "rdbExcel2013";
            this.rdbExcel2013.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2013.TabIndex = 2;
            this.rdbExcel2013.Text = "Excel 2013";
            this.rdbExcel2013.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2010
            // 
            this.rdbExcel2010.AutoSize = true;
            this.rdbExcel2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2010.Location = new System.Drawing.Point(104, 11);
            this.rdbExcel2010.Name = "rdbExcel2010";
            this.rdbExcel2010.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2010.TabIndex = 1;
            this.rdbExcel2010.Text = "Excel 2010";
            this.rdbExcel2010.UseVisualStyleBackColor = true;
            // 
            // rdbExcel2007
            // 
            this.rdbExcel2007.AutoSize = true;
            this.rdbExcel2007.Checked = true;
            this.rdbExcel2007.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcel2007.Location = new System.Drawing.Point(20, 11);
            this.rdbExcel2007.Name = "rdbExcel2007";
            this.rdbExcel2007.Size = new System.Drawing.Size(78, 17);
            this.rdbExcel2007.TabIndex = 0;
            this.rdbExcel2007.TabStop = true;
            this.rdbExcel2007.Text = "Excel 2007";
            this.rdbExcel2007.UseVisualStyleBackColor = true;
            // 
            // btnCustomize
            // 
            this.btnCustomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomize.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomize.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomize.Image")));
            this.btnCustomize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomize.Location = new System.Drawing.Point(273, 294);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(137, 26);
            this.btnCustomize.TabIndex = 71;
            this.btnCustomize.Text = "Customize Pivot Table";
            this.btnCustomize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomize.UseVisualStyleBackColor = false;
            this.btnCustomize.Click += new System.EventHandler(this.btnCustomize_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckbColumnFieldFilter);
            this.groupBox3.Controls.Add(this.ckbRowFieldFilter);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(132, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 94);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Row and Column Filter";
            // 
            // ckbColumnFieldFilter
            // 
            this.ckbColumnFieldFilter.AutoSize = true;
            this.ckbColumnFieldFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbColumnFieldFilter.Location = new System.Drawing.Point(127, 19);
            this.ckbColumnFieldFilter.Name = "ckbColumnFieldFilter";
            this.ckbColumnFieldFilter.Size = new System.Drawing.Size(86, 17);
            this.ckbColumnFieldFilter.TabIndex = 3;
            this.ckbColumnFieldFilter.Text = "Column Filter";
            this.ckbColumnFieldFilter.UseVisualStyleBackColor = true;
            this.ckbColumnFieldFilter.CheckedChanged += new System.EventHandler(this.ckbColumnFieldFilter_CheckedChanged);
            // 
            // ckbRowFieldFilter
            // 
            this.ckbRowFieldFilter.AutoSize = true;
            this.ckbRowFieldFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRowFieldFilter.Location = new System.Drawing.Point(17, 18);
            this.ckbRowFieldFilter.Name = "ckbRowFieldFilter";
            this.ckbRowFieldFilter.Size = new System.Drawing.Size(73, 17);
            this.ckbRowFieldFilter.TabIndex = 2;
            this.ckbRowFieldFilter.Text = "Row Filter";
            this.ckbRowFieldFilter.UseVisualStyleBackColor = true;
            this.ckbRowFieldFilter.CheckedChanged += new System.EventHandler(this.ckbRowFieldFilter_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.multipleFilter);
            this.groupBox5.Controls.Add(this.rdbRCValueFilter);
            this.groupBox5.Controls.Add(this.rdbRCLabelFilter);
            this.groupBox5.Location = new System.Drawing.Point(7, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(246, 54);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // multipleFilter
            // 
            this.multipleFilter.AutoSize = true;
            this.multipleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multipleFilter.Location = new System.Drawing.Point(120, 11);
            this.multipleFilter.Name = "multipleFilter";
            this.multipleFilter.Size = new System.Drawing.Size(115, 17);
            this.multipleFilter.TabIndex = 2;
            this.multipleFilter.TabStop = true;
            this.multipleFilter.Text = "Apply Multiple Filter";
            this.multipleFilter.UseVisualStyleBackColor = true;
            // 
            // rdbRCValueFilter
            // 
            this.rdbRCValueFilter.AutoSize = true;
            this.rdbRCValueFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRCValueFilter.Location = new System.Drawing.Point(9, 31);
            this.rdbRCValueFilter.Name = "rdbRCValueFilter";
            this.rdbRCValueFilter.Size = new System.Drawing.Size(77, 17);
            this.rdbRCValueFilter.TabIndex = 1;
            this.rdbRCValueFilter.TabStop = true;
            this.rdbRCValueFilter.Text = "Value Filter";
            this.rdbRCValueFilter.UseVisualStyleBackColor = true;
            // 
            // rdbRCLabelFilter
            // 
            this.rdbRCLabelFilter.AutoSize = true;
            this.rdbRCLabelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRCLabelFilter.Location = new System.Drawing.Point(9, 11);
            this.rdbRCLabelFilter.Name = "rdbRCLabelFilter";
            this.rdbRCLabelFilter.Size = new System.Drawing.Size(105, 17);
            this.rdbRCLabelFilter.TabIndex = 0;
            this.rdbRCLabelFilter.TabStop = true;
            this.rdbRCLabelFilter.Text = "Apply Label Filter";
            this.rdbRCLabelFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbMultiplePageFilter);
            this.groupBox2.Controls.Add(this.ckbPageFilter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Page Filter";
            // 
            // ckbMultiplePageFilter
            // 
            this.ckbMultiplePageFilter.AutoSize = true;
            this.ckbMultiplePageFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMultiplePageFilter.Location = new System.Drawing.Point(7, 49);
            this.ckbMultiplePageFilter.Name = "ckbMultiplePageFilter";
            this.ckbMultiplePageFilter.Size = new System.Drawing.Size(116, 17);
            this.ckbMultiplePageFilter.TabIndex = 1;
            this.ckbMultiplePageFilter.Text = "Apply Multiple Filter";
            this.ckbMultiplePageFilter.UseVisualStyleBackColor = true;
            this.ckbMultiplePageFilter.CheckedChanged += new System.EventHandler(this.ckbMultiplePageFilter_CheckedChanged);
            // 
            // ckbPageFilter
            // 
            this.ckbPageFilter.AutoSize = true;
            this.ckbPageFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPageFilter.Location = new System.Drawing.Point(7, 25);
            this.ckbPageFilter.Name = "ckbPageFilter";
            this.ckbPageFilter.Size = new System.Drawing.Size(76, 17);
            this.ckbPageFilter.TabIndex = 0;
            this.ckbPageFilter.Text = "Page Filter";
            this.ckbPageFilter.UseVisualStyleBackColor = true;
            this.ckbPageFilter.CheckedChanged += new System.EventHandler(this.ckbPageFilter_CheckedChanged);
            // 
            // ckbApplyGrouping
            // 
            this.ckbApplyGrouping.AutoSize = true;
            this.ckbApplyGrouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbApplyGrouping.Location = new System.Drawing.Point(10, 235);
            this.ckbApplyGrouping.Name = "ckbApplyGrouping";
            this.ckbApplyGrouping.Size = new System.Drawing.Size(76, 17);
            //this.ckbApplyGrouping.TabIndex = 0;
            this.ckbApplyGrouping.Text = "Apply Grouping";
            this.ckbApplyGrouping.UseVisualStyleBackColor = true;
            // 
            // PivotTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ckbApplyGrouping);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCustomize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PivotTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pivot Table";
            this.Load += new System.EventHandler(this.PivotTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ckbApplyGrouping.ResumeLayout(false);
            this.ckbApplyGrouping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbExcel2010;
        private System.Windows.Forms.RadioButton rdbExcel2007;
        private System.Windows.Forms.Button btnCustomize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton multipleFilter;
        private System.Windows.Forms.RadioButton rdbRCValueFilter;
        private System.Windows.Forms.RadioButton rdbRCLabelFilter;
        private System.Windows.Forms.CheckBox ckbColumnFieldFilter;
        private System.Windows.Forms.CheckBox ckbRowFieldFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbPageFilter;
        private System.Windows.Forms.CheckBox ckbMultiplePageFilter;
        private System.Windows.Forms.CheckBox ckbApplyGrouping;
        private System.Windows.Forms.RadioButton rdbExcel2013;
    }
}

