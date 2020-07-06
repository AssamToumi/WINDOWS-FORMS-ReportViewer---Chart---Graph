namespace ChartExample
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartSalary
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartSalary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartSalary.Legends.Add(legend1);
            this.ChartSalary.Location = new System.Drawing.Point(12, 12);
            this.ChartSalary.Name = "ChartSalary";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.ChartSalary.Series.Add(series1);
            this.ChartSalary.Size = new System.Drawing.Size(336, 341);
            this.ChartSalary.TabIndex = 0;
            this.ChartSalary.Text = "chartSalary";
            title1.Name = "Title1";
            title1.Text = "Salary Chart";
            this.ChartSalary.Titles.Add(title1);
            // 
            // ChartRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartRevenue.Legends.Add(legend2);
            this.ChartRevenue.Location = new System.Drawing.Point(354, 12);
            this.ChartRevenue.Name = "ChartRevenue";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            this.ChartRevenue.Series.Add(series2);
            this.ChartRevenue.Size = new System.Drawing.Size(336, 341);
            this.ChartRevenue.TabIndex = 1;
            this.ChartRevenue.Text = "ChartRevenue";
            title2.Name = "Title1";
            title2.Text = "Revenue Chart";
            this.ChartRevenue.Titles.Add(title2);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(575, 359);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 389);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.ChartRevenue);
            this.Controls.Add(this.ChartSalary);
            this.Name = "Form1";
            this.Text = "Graph / Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSalary;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartRevenue;
        private System.Windows.Forms.Button btnLoad;
    }
}

