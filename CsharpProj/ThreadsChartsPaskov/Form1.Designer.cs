using System;
using System.Windows.Forms;

namespace ThreadsChartsPaskov
{
    partial class Form1
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.btnLoadnoSleep = new System.Windows.Forms.Button();
            this.chartDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAxisX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(43, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1115, 309);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // btnLoadnoSleep
            // 
            this.btnLoadnoSleep.Location = new System.Drawing.Point(64, 589);
            this.btnLoadnoSleep.Name = "btnLoadnoSleep";
            this.btnLoadnoSleep.Size = new System.Drawing.Size(128, 44);
            this.btnLoadnoSleep.TabIndex = 3;
            this.btnLoadnoSleep.Text = "Load Data";
            this.btnLoadnoSleep.UseVisualStyleBackColor = true;
            this.btnLoadnoSleep.Click += new System.EventHandler(this.btnLoadnoSleep_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(64, 381);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(249, 173);
            this.listBox.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.33205F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.66795F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(361, 381);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 283);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1111, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Threads";
            // 
            // lblAxisX
            // 
            this.lblAxisX.AutoSize = true;
            this.lblAxisX.Location = new System.Drawing.Point(40, 12);
            this.lblAxisX.Name = "lblAxisX";
            this.lblAxisX.Size = new System.Drawing.Size(55, 13);
            this.lblAxisX.TabIndex = 7;
            this.lblAxisX.Text = "Speed Up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 707);
            this.Controls.Add(this.lblAxisX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnLoadnoSleep);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreadsChart";
            ((System.ComponentModel.ISupportInitialize)(this.chartDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLoadnoSleep;
        private BindingSource chartDataBindingSource;
        private ListBox listBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label lblAxisX;
    }
}

