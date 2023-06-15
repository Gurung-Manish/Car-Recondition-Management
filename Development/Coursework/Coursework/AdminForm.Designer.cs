
namespace Coursework
{
    partial class AdminForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.criteriaTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCriteriaBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bulkImportBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.showChartBtn = new System.Windows.Forms.Button();
            this.viewReportBtn = new System.Windows.Forms.Button();
            this.generateReportGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // criteriaTb
            // 
            this.criteriaTb.Location = new System.Drawing.Point(854, 514);
            this.criteriaTb.Name = "criteriaTb";
            this.criteriaTb.Size = new System.Drawing.Size(221, 22);
            this.criteriaTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(716, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criteria";
            // 
            // addCriteriaBtn
            // 
            this.addCriteriaBtn.BackColor = System.Drawing.Color.White;
            this.addCriteriaBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCriteriaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.addCriteriaBtn.Location = new System.Drawing.Point(1098, 496);
            this.addCriteriaBtn.Name = "addCriteriaBtn";
            this.addCriteriaBtn.Size = new System.Drawing.Size(150, 40);
            this.addCriteriaBtn.TabIndex = 2;
            this.addCriteriaBtn.Text = "Add Criteria";
            this.addCriteriaBtn.UseVisualStyleBackColor = false;
            this.addCriteriaBtn.Click += new System.EventHandler(this.addCriteriaBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addCriteriaBtn);
            this.panel2.Controls.Add(this.criteriaTb);
            this.panel2.Controls.Add(this.bulkImportBtn);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.showChartBtn);
            this.panel2.Controls.Add(this.viewReportBtn);
            this.panel2.Controls.Add(this.generateReportGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 670);
            this.panel2.TabIndex = 2;
            // 
            // bulkImportBtn
            // 
            this.bulkImportBtn.BackColor = System.Drawing.Color.White;
            this.bulkImportBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.bulkImportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bulkImportBtn.Location = new System.Drawing.Point(51, 574);
            this.bulkImportBtn.Name = "bulkImportBtn";
            this.bulkImportBtn.Size = new System.Drawing.Size(150, 40);
            this.bulkImportBtn.TabIndex = 5;
            this.bulkImportBtn.Text = "Bulk Import";
            this.bulkImportBtn.UseVisualStyleBackColor = false;
            this.bulkImportBtn.Click += new System.EventHandler(this.bulkImportBtn_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(51, 42);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1197, 372);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            this.chart1.Visible = false;
            // 
            // showChartBtn
            // 
            this.showChartBtn.BackColor = System.Drawing.Color.White;
            this.showChartBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.showChartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.showChartBtn.Location = new System.Drawing.Point(1098, 574);
            this.showChartBtn.Name = "showChartBtn";
            this.showChartBtn.Size = new System.Drawing.Size(150, 40);
            this.showChartBtn.TabIndex = 3;
            this.showChartBtn.Text = "Show Chart";
            this.showChartBtn.UseVisualStyleBackColor = false;
            this.showChartBtn.Click += new System.EventHandler(this.showChartBtn_Click);
            // 
            // viewReportBtn
            // 
            this.viewReportBtn.BackColor = System.Drawing.Color.White;
            this.viewReportBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.viewReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.viewReportBtn.Location = new System.Drawing.Point(314, 574);
            this.viewReportBtn.Name = "viewReportBtn";
            this.viewReportBtn.Size = new System.Drawing.Size(150, 40);
            this.viewReportBtn.TabIndex = 1;
            this.viewReportBtn.Text = "View Report";
            this.viewReportBtn.UseVisualStyleBackColor = false;
            this.viewReportBtn.Click += new System.EventHandler(this.viewReportBtn_Click);
            // 
            // generateReportGridView
            // 
            this.generateReportGridView.AllowUserToAddRows = false;
            this.generateReportGridView.AllowUserToDeleteRows = false;
            this.generateReportGridView.AllowUserToResizeColumns = false;
            this.generateReportGridView.AllowUserToResizeRows = false;
            this.generateReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generateReportGridView.Location = new System.Drawing.Point(51, 42);
            this.generateReportGridView.Name = "generateReportGridView";
            this.generateReportGridView.ReadOnly = true;
            this.generateReportGridView.RowHeadersWidth = 51;
            this.generateReportGridView.RowTemplate.Height = 24;
            this.generateReportGridView.Size = new System.Drawing.Size(1197, 372);
            this.generateReportGridView.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1288, 670);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1017, 609);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Admin Panel";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateReportGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox criteriaTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCriteriaBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView generateReportGridView;
        private System.Windows.Forms.Button viewReportBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button showChartBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bulkImportBtn;
    }
}