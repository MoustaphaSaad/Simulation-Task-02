namespace Simulation_Task_02
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InputTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRandomMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutputTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.IDSimLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AmountMAXNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.RangeNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ScrapPriceNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SalePriceNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BuyPriceNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountMINNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DaysNum = new System.Windows.Forms.NumericUpDown();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.OutputGrid = new System.Windows.Forms.DataGridView();
            this.TotalNUnsold = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TotalNExcess = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TotalNetProfit = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TotalScrapRev = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalLostProfit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalSaleRev = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChartTab = new System.Windows.Forms.TabPage();
            this.OutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.InputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.OutputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountMAXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapPriceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePriceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountMINNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputGrid)).BeginInit();
            this.ChartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InputTab);
            this.tabControl1.Controls.Add(this.OutputTab);
            this.tabControl1.Controls.Add(this.ChartTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 607);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // InputTab
            // 
            this.InputTab.Controls.Add(this.splitContainer1);
            this.InputTab.Controls.Add(this.menuStrip1);
            this.InputTab.Location = new System.Drawing.Point(4, 22);
            this.InputTab.Name = "InputTab";
            this.InputTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputTab.Size = new System.Drawing.Size(960, 581);
            this.InputTab.TabIndex = 0;
            this.InputTab.Text = "Input";
            this.InputTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(954, 551);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(226, 551);
            this.dataGridView2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testDataToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.generateRandomMachineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testDataToolStripMenuItem
            // 
            this.testDataToolStripMenuItem.Name = "testDataToolStripMenuItem";
            this.testDataToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.testDataToolStripMenuItem.Text = "Test Data";
            this.testDataToolStripMenuItem.Click += new System.EventHandler(this.testDataToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // generateRandomMachineToolStripMenuItem
            // 
            this.generateRandomMachineToolStripMenuItem.Name = "generateRandomMachineToolStripMenuItem";
            this.generateRandomMachineToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.generateRandomMachineToolStripMenuItem.Text = "Generate Random Machine";
            this.generateRandomMachineToolStripMenuItem.Click += new System.EventHandler(this.generateRandomMachineToolStripMenuItem_Click);
            // 
            // OutputTab
            // 
            this.OutputTab.Controls.Add(this.splitContainer2);
            this.OutputTab.Location = new System.Drawing.Point(4, 22);
            this.OutputTab.Name = "OutputTab";
            this.OutputTab.Padding = new System.Windows.Forms.Padding(3);
            this.OutputTab.Size = new System.Drawing.Size(960, 581);
            this.OutputTab.TabIndex = 1;
            this.OutputTab.Text = "Output";
            this.OutputTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.linkLabel2);
            this.splitContainer2.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer2.Panel1.Controls.Add(this.IDSimLabel);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.AmountMAXNum);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.RangeNum);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.ScrapPriceNum);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.SalePriceNum);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.BuyPriceNum);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.AmountMINNum);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.DaysNum);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(954, 575);
            this.splitContainer2.SplitterDistance = 104;
            this.splitContainer2.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(78, 530);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(15, 13);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = ">";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 530);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(15, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // IDSimLabel
            // 
            this.IDSimLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IDSimLabel.AutoSize = true;
            this.IDSimLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSimLabel.Location = new System.Drawing.Point(18, 513);
            this.IDSimLabel.Name = "IDSimLabel";
            this.IDSimLabel.Size = new System.Drawing.Size(68, 45);
            this.IDSimLabel.TabIndex = 15;
            this.IDSimLabel.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount MAX:";
            // 
            // AmountMAXNum
            // 
            this.AmountMAXNum.Location = new System.Drawing.Point(5, 104);
            this.AmountMAXNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AmountMAXNum.Name = "AmountMAXNum";
            this.AmountMAXNum.Size = new System.Drawing.Size(85, 20);
            this.AmountMAXNum.TabIndex = 13;
            this.AmountMAXNum.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Range";
            // 
            // RangeNum
            // 
            this.RangeNum.DecimalPlaces = 2;
            this.RangeNum.Location = new System.Drawing.Point(5, 281);
            this.RangeNum.Name = "RangeNum";
            this.RangeNum.Size = new System.Drawing.Size(85, 20);
            this.RangeNum.TabIndex = 11;
            this.RangeNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scrap Price";
            // 
            // ScrapPriceNum
            // 
            this.ScrapPriceNum.DecimalPlaces = 2;
            this.ScrapPriceNum.Location = new System.Drawing.Point(5, 236);
            this.ScrapPriceNum.Name = "ScrapPriceNum";
            this.ScrapPriceNum.Size = new System.Drawing.Size(85, 20);
            this.ScrapPriceNum.TabIndex = 9;
            this.ScrapPriceNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sale Price:";
            // 
            // SalePriceNum
            // 
            this.SalePriceNum.DecimalPlaces = 2;
            this.SalePriceNum.Location = new System.Drawing.Point(5, 192);
            this.SalePriceNum.Name = "SalePriceNum";
            this.SalePriceNum.Size = new System.Drawing.Size(85, 20);
            this.SalePriceNum.TabIndex = 7;
            this.SalePriceNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buy Price:";
            // 
            // BuyPriceNum
            // 
            this.BuyPriceNum.DecimalPlaces = 2;
            this.BuyPriceNum.Location = new System.Drawing.Point(5, 145);
            this.BuyPriceNum.Name = "BuyPriceNum";
            this.BuyPriceNum.Size = new System.Drawing.Size(85, 20);
            this.BuyPriceNum.TabIndex = 5;
            this.BuyPriceNum.Value = new decimal(new int[] {
            33,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount MIN:";
            // 
            // AmountMINNum
            // 
            this.AmountMINNum.Location = new System.Drawing.Point(5, 62);
            this.AmountMINNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AmountMINNum.Name = "AmountMINNum";
            this.AmountMINNum.Size = new System.Drawing.Size(85, 20);
            this.AmountMINNum.TabIndex = 3;
            this.AmountMINNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Days:";
            // 
            // DaysNum
            // 
            this.DaysNum.Location = new System.Drawing.Point(5, 22);
            this.DaysNum.Name = "DaysNum";
            this.DaysNum.Size = new System.Drawing.Size(85, 20);
            this.DaysNum.TabIndex = 0;
            this.DaysNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.OutputGrid);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.TotalNUnsold);
            this.splitContainer3.Panel2.Controls.Add(this.label19);
            this.splitContainer3.Panel2.Controls.Add(this.TotalNExcess);
            this.splitContainer3.Panel2.Controls.Add(this.label17);
            this.splitContainer3.Panel2.Controls.Add(this.TotalNetProfit);
            this.splitContainer3.Panel2.Controls.Add(this.label15);
            this.splitContainer3.Panel2.Controls.Add(this.TotalScrapRev);
            this.splitContainer3.Panel2.Controls.Add(this.label13);
            this.splitContainer3.Panel2.Controls.Add(this.TotalLostProfit);
            this.splitContainer3.Panel2.Controls.Add(this.label11);
            this.splitContainer3.Panel2.Controls.Add(this.TotalCost);
            this.splitContainer3.Panel2.Controls.Add(this.label9);
            this.splitContainer3.Panel2.Controls.Add(this.TotalSaleRev);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Size = new System.Drawing.Size(846, 575);
            this.splitContainer3.SplitterDistance = 499;
            this.splitContainer3.TabIndex = 1;
            // 
            // OutputGrid
            // 
            this.OutputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputGrid.Location = new System.Drawing.Point(0, 0);
            this.OutputGrid.Name = "OutputGrid";
            this.OutputGrid.Size = new System.Drawing.Size(846, 499);
            this.OutputGrid.TabIndex = 0;
            // 
            // TotalNUnsold
            // 
            this.TotalNUnsold.AutoSize = true;
            this.TotalNUnsold.Location = new System.Drawing.Point(717, 27);
            this.TotalNUnsold.Name = "TotalNUnsold";
            this.TotalNUnsold.Size = new System.Drawing.Size(29, 13);
            this.TotalNUnsold.TabIndex = 13;
            this.TotalNUnsold.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(680, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Total # Unsold Papers";
            // 
            // TotalNExcess
            // 
            this.TotalNExcess.AutoSize = true;
            this.TotalNExcess.Location = new System.Drawing.Point(579, 27);
            this.TotalNExcess.Name = "TotalNExcess";
            this.TotalNExcess.Size = new System.Drawing.Size(29, 13);
            this.TotalNExcess.TabIndex = 11;
            this.TotalNExcess.Text = "0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(540, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Total # Excess Demand";
            // 
            // TotalNetProfit
            // 
            this.TotalNetProfit.AutoSize = true;
            this.TotalNetProfit.Location = new System.Drawing.Point(464, 27);
            this.TotalNetProfit.Name = "TotalNetProfit";
            this.TotalNetProfit.Size = new System.Drawing.Size(29, 13);
            this.TotalNetProfit.TabIndex = 9;
            this.TotalNetProfit.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(441, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Total Net Profit";
            // 
            // TotalScrapRev
            // 
            this.TotalScrapRev.AutoSize = true;
            this.TotalScrapRev.Location = new System.Drawing.Point(349, 27);
            this.TotalScrapRev.Name = "TotalScrapRev";
            this.TotalScrapRev.Size = new System.Drawing.Size(29, 13);
            this.TotalScrapRev.TabIndex = 7;
            this.TotalScrapRev.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total Scrap Revenue";
            // 
            // TotalLostProfit
            // 
            this.TotalLostProfit.AutoSize = true;
            this.TotalLostProfit.Location = new System.Drawing.Point(236, 27);
            this.TotalLostProfit.Name = "TotalLostProfit";
            this.TotalLostProfit.Size = new System.Drawing.Size(29, 13);
            this.TotalLostProfit.TabIndex = 5;
            this.TotalLostProfit.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Total Lost Profit";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(148, 27);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(29, 13);
            this.TotalCost.TabIndex = 3;
            this.TotalCost.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total Cost";
            // 
            // TotalSaleRev
            // 
            this.TotalSaleRev.AutoSize = true;
            this.TotalSaleRev.Location = new System.Drawing.Point(42, 27);
            this.TotalSaleRev.Name = "TotalSaleRev";
            this.TotalSaleRev.Size = new System.Drawing.Size(29, 13);
            this.TotalSaleRev.TabIndex = 1;
            this.TotalSaleRev.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Sale Revenue";
            // 
            // ChartTab
            // 
            this.ChartTab.Controls.Add(this.OutputChart);
            this.ChartTab.Location = new System.Drawing.Point(4, 22);
            this.ChartTab.Name = "ChartTab";
            this.ChartTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChartTab.Size = new System.Drawing.Size(960, 581);
            this.ChartTab.TabIndex = 2;
            this.ChartTab.Text = "Charts";
            this.ChartTab.UseVisualStyleBackColor = true;
            // 
            // OutputChart
            // 
            chartArea1.Name = "ChartArea1";
            this.OutputChart.ChartAreas.Add(chartArea1);
            this.OutputChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.OutputChart.Legends.Add(legend1);
            this.OutputChart.Location = new System.Drawing.Point(3, 3);
            this.OutputChart.Name = "OutputChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DailyProfit";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.OutputChart.Series.Add(series1);
            this.OutputChart.Size = new System.Drawing.Size(954, 575);
            this.OutputChart.TabIndex = 0;
            this.OutputChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 607);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.InputTab.ResumeLayout(false);
            this.InputTab.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.OutputTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountMAXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapPriceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePriceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountMINNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysNum)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputGrid)).EndInit();
            this.ChartTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InputTab;
        private System.Windows.Forms.TabPage OutputTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testDataToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DaysNum;
        private System.Windows.Forms.DataGridView OutputGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ScrapPriceNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SalePriceNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BuyPriceNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AmountMINNum;
        private System.Windows.Forms.ToolStripMenuItem generateRandomMachineToolStripMenuItem;
        private System.Windows.Forms.TabPage ChartTab;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label TotalNUnsold;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label TotalNExcess;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TotalNetProfit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label TotalScrapRev;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TotalLostProfit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TotalSaleRev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown RangeNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown AmountMAXNum;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label IDSimLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutputChart;
    }
}

