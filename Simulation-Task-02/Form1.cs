using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simulation_Task_02
{
    public partial class Form1 : Form
    {
        private Simulator2000 simulator2000;
        private BindingList<DayInfo> d_pDays;
        private BindingList<DemandInfo> d_pDemands;
        private List<BindingList<SimulationInfo>> d_pSimulations;
        private List<ReportInfo> d_pReportInfo;
        private List<Dictionary<double, int>> d_pFreq;
        private List<Tuple<double, double>> d_ChartLimits;
        private int iSim;
        private bool s;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

            d_pDays = new BindingList<DayInfo>();
            d_pDemands = new BindingList<DemandInfo>();
            d_pSimulations = new List<BindingList<SimulationInfo>>();
            d_pReportInfo = new List<ReportInfo>();
            d_pFreq = new List<Dictionary<double, int>>();
            d_ChartLimits = new List<Tuple<double, double>>();
            iSim = 0;
            s = false;

            dataGridView1.DataSource = d_pDemands;
            dataGridView2.DataSource = d_pDays;
        }

        private void testDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] P = new double[3] { 0.35, 0.45, 0.20 };
            double[] P_Good = new double[7] { 0.03, 0.05, 0.15, 0.20, 0.35, 0.15, 0.07 };
            double[] P_Fair = new double[7] { 0.10, 0.18, 0.40, 0.20, 0.08, 0.04, 0.00 };
            double[] P_Poor = new double[7] { 0.44, 0.22, 0.16, 0.12, 0.06, 0.00, 0.00 };
            
            populateInputData(P,P_Good,P_Fair,P_Poor);
            generateRandomMachine();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d_pDays.Clear();
            d_pDemands.Clear();
            simulator2000 = null;
        }

        private void generateRandomMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateRandomMachine();
        }
        
        private void populateInputData(double[] P, double[] good, double[] fair, double[] poor)
        {
            d_pDays.Clear();
            d_pDemands.Clear();
            foreach (var d in P)
                d_pDays.Add(new DayInfo() { DayProbability = d });

            for (int i = 0; i < good.Length; i++)
                d_pDemands.Add(new DemandInfo() { Good = good[i], Fair = fair[i], Poor = poor[i] });

        }

        private void generateRandomMachine()
        {
            if(d_pDays.Count == 0 || d_pDemands.Count == 0)
                throw new Exception("You must enter atleast one row as input");

            double[] p = new double[d_pDays.Count];
            double[] good = new double[d_pDemands.Count];
            double[] fair = new double[d_pDemands.Count];
            double[] poor = new double[d_pDemands.Count];

            for (int i = 0; i < p.Length; ++i)
                p[i] = d_pDays[i].DayProbability;

            for (int i = 0; i < good.Length; ++i)
            {
                good[i] = d_pDemands[i].Good;
                fair[i] = d_pDemands[i].Fair;
                poor[i] = d_pDemands[i].Poor;
            }

            var randomMachine = new RandomMachine(p,good,fair,poor);
            simulator2000 = new Simulator2000(randomMachine);
        }

        private double Round(double range, double val)
        {
            int r = (int)(Math.Abs(val) / range);
            if (val < 0)
                return r * range * -1;
            else
                return r * range;
        }

        private void viewData()
        {
            double range = (double)RangeNum.Value;
            OutputGrid.DataSource = d_pSimulations[iSim];

            var minChart = d_ChartLimits[iSim].Item1;
            var maxChart = d_ChartLimits[iSim].Item2;

            OutputChart.Series[0].Points.Clear();
            OutputChart.ChartAreas[0].AxisX.Maximum = Round(range, maxChart) + 1;
            OutputChart.ChartAreas[0].AxisX.Minimum = Round(range, minChart) - 1;
            OutputChart.ChartAreas[0].AxisX.Interval = range;

            foreach (var element in d_pFreq[iSim])
            {
                OutputChart.Series[0].Points.AddXY(element.Key, element.Value);
            }

            TotalSaleRev.Text = d_pReportInfo[iSim].TotalSalRevenue.ToString();
            TotalCost.Text = d_pReportInfo[iSim].TotalNewsCost.ToString();
            TotalLostProfit.Text = d_pReportInfo[iSim].TotalLostProfit.ToString();
            TotalScrapRev.Text = d_pReportInfo[iSim].TotalScrapRevenue.ToString();
            TotalNetProfit.Text = d_pReportInfo[iSim].TotalNetProfit.ToString();
            TotalNExcess.Text = d_pReportInfo[iSim].TotalDaysExcess.ToString();
            TotalNUnsold.Text = d_pReportInfo[iSim].TotalDaysUnsold.ToString();

            IDSimLabel.Text = (AmountMINNum.Value + iSim * 10).ToString();
            s = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startAmount = (int)AmountMINNum.Value;
            int endAmount = (int)AmountMAXNum.Value;

            if (endAmount < startAmount)
                return;

            d_pSimulations.Clear();
            d_pFreq.Clear();
            d_pReportInfo.Clear();
            d_ChartLimits.Clear();
            iSim = 0;

            double range = (double)RangeNum.Value;

            for (int i = startAmount; i <= endAmount; i+=10)
            {
                var simData = simulator2000.Simulate((int)DaysNum.Value, (double)BuyPriceNum.Value,
                    (double)SalePriceNum.Value, (double)ScrapPriceNum.Value, (int)i);

                Dictionary<double, int> freq = new Dictionary<double, int>();

                BindingList<SimulationInfo> element_list = new BindingList<SimulationInfo>();

                foreach (var element in simData)
                {
                    element_list.Add(element);

                    double rv = Round(range, element.daily_profit);

                    if (!freq.ContainsKey(rv))
                    {
                        freq.Add(rv, 1);
                    }
                    else
                    {
                        freq[rv]++;
                    }
                }

                d_pSimulations.Add(element_list);
                d_pFreq.Add(freq);

                ReportInfo report = new ReportInfo()
                {
                    TotalSalRevenue = simulator2000.TotalSaleRevenue,
                    TotalNewsCost = simulator2000.TotalNewsCost,
                    TotalLostProfit = simulator2000.TotalLostProfit,
                    TotalScrapRevenue = simulator2000.TotalScrapRevenue,
                    TotalNetProfit = simulator2000.TotalNetProfit,
                    TotalDaysExcess = simulator2000.TotalDaysExcess,
                    TotalDaysUnsold = simulator2000.TotalDaysUnsold
                };
                d_pReportInfo.Add(report);
                d_ChartLimits.Add(new Tuple<double, double>(simulator2000.MinimumProfit, simulator2000.MaximumProfit));
            }

            viewData();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (iSim == 0)
                return;
            iSim--;
            viewData();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (iSim == d_pSimulations.Count-1)
                return;
            iSim++;
            viewData();
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (s)
                return;

            if (e.KeyCode == Keys.Up)
            {
                if (iSim == 0)
                    return;
                iSim--;
                viewData();
                s = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (iSim == d_pSimulations.Count - 1)
                    return;
                iSim++;
                viewData();
                s = true;
            }
        }
    }
}
