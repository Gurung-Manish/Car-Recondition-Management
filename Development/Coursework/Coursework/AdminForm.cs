using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Coursework
{
    public partial class AdminForm : Form
    {

        DataTable dt = new DataTable();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void addCriteriaBtn_Click(object sender, EventArgs e)
        {
            String criteria = criteriaTb.Text;
            String filePath = "criteria.csv";
            if (File.Exists(filePath))
            {
                var csv = File.ReadLines(filePath)
                    .Select((line, index) => index == 0 ? (
                    line + "," + criteria
                )
                    : line + ",").ToList();
                File.WriteAllLines(filePath, csv);
                criteriaTb.Text = "";
            }
            else
            {
                var csv = criteria;
                File.WriteAllText(filePath, csv);
                criteriaTb.Text = "";
            }
        }
        
        private void viewReportBtn_Click(object sender, EventArgs e)
        {
            String filePath = "rating.csv";
            createTable(filePath);
        }

        private void createTable(String filePath)
        {
            chart1.Visible = false;
            dt.Rows.Clear();
            dt.Columns.Clear();

            ArrayList reportHeader = new ArrayList();
            reportHeader.Add("Name");
            reportHeader.Add("Email");
            reportHeader.Add("Contact Number");
            reportHeader.Add("Overall Feedback");
            reportHeader.Add("System Date");
            reportHeader.Add("System Time");


            String headerPath = "criteria.csv";
            string[] lines = File.ReadAllLines(filePath);
            string[] headerLine = File.ReadAllLines(headerPath);

            string firstLine = headerLine[0];
            string[] headerLabels = firstLine.Split(',');

            for(int i = 0; i < headerLabels.Length; i++)
            {
                reportHeader.Add(headerLabels[i]);
            }
            if (lines.Length > 0)
            {

                foreach (string headerWord in reportHeader)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                for (int r = 0; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in reportHeader)
                    {
                        try
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        catch
                        {
                            dr[headerWord] = 0;
                            columnIndex++;
                        }

                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                generateReportGridView.DataSource = dt;
            }
        }

        private void showChartBtn_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            string seriesname = "Rating Chart";
            chart1.Series.Clear();
            int row = generateReportGridView.Rows.Count;
            int col = generateReportGridView.Columns.Count;

            List<string> header = new List<string>();
            List<int> totalValues = new List<int>();

            for (int i = 6; i < col; i++)
            {
                header.Add(generateReportGridView.Columns[i].HeaderText);
                int total = 0;

                for (int j = 0; j < row; j++)
                {
                    try
                    {
                        total += Convert.ToInt16(generateReportGridView.Rows[j].Cells[i].Value);
                    }
                    catch
                    {
                        total += 0;
                    }
                }
                totalValues.Add(total);
            }
            decimal totalsum = 0;

            for (int i = 0; i < col - 6; i++)
            {
                totalsum += totalValues[i];
            }
            chart1.Series.Add(seriesname);
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
            chart1.Series[seriesname].Points.DataBindY(totalValues);

            List<decimal> percentList = new List<decimal>();

            for (int i = 0; i < header.Count; i++)
            {
                decimal percent = (totalValues[i] / totalsum) * 100;

                decimal finalPercent = decimal.Round(percent, 2, MidpointRounding.AwayFromZero);
                percentList.Add(finalPercent);
            }
            int count = percentList.Count;

            decimal temp;
            string criteriaTemp;

            //Sorting
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (percentList[j] < percentList[j + 1])
                    {
                        temp = percentList[j];
                        percentList[j] = percentList[j + 1];
                        percentList[j + 1] = temp;

                        criteriaTemp = header[j];
                        header[j] = header[j + 1];
                        header[j + 1] = criteriaTemp;
                    }
                }
            }

            for (int i = 0; i < header.Count; i++)
            {
                chart1.Series[seriesname].Points[i].Label = percentList[i] + @"%";
                chart1.Series[seriesname].Points[i].LegendText = header[i];
            }
            chart1.Titles[0].Text = "Rating Chart";
            chart1.Titles[0].Alignment = ContentAlignment.TopCenter;
        }

        private void bulkImportBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            addDataToTable(openFileDialog1.FileName);
        }

        public void addDataToTable(String filePath)
        {
            ArrayList reportHeader = new ArrayList();
            reportHeader.Add("Name");
            reportHeader.Add("Email");
            reportHeader.Add("Contact Number");
            reportHeader.Add("Overall Feedback");
            reportHeader.Add("System Date");
            reportHeader.Add("System Time");


            String headerPath = "criteria.csv";
            string[] lines = File.ReadAllLines(filePath);
            string[] headerLine = File.ReadAllLines(headerPath);

            string firstLine = headerLine[0];
            string[] headerLabels = firstLine.Split(',');

            for (int i = 0; i < headerLabels.Length; i++)
            {
                reportHeader.Add(headerLabels[i]);
            }
            if (lines.Length > 0)
            {

                
                for (int r = 0; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in reportHeader)
                    {
                        try
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        catch
                        {
                            dr[headerWord] = 0;
                            columnIndex++;
                        }

                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                generateReportGridView.DataSource = dt;
            }
        }
    }
}
