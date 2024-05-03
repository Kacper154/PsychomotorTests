namespace testy_projekt_posk
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.akustyczneButton = new System.Windows.Forms.Button();
            this.wizualnyPrzycisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wizualnyPanel = new System.Windows.Forms.Panel();
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averageLabel = new System.Windows.Forms.Label();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.startstopButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.akustyczny = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.stop_acustic = new System.Windows.Forms.Button();
            this.akustyczny_label = new System.Windows.Forms.Label();
            this.Start_akust = new System.Windows.Forms.Button();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuPanel.SuspendLayout();
            this.wizualnyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            this.akustyczny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.akustyczneButton);
            this.menuPanel.Controls.Add(this.wizualnyPrzycisk);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Location = new System.Drawing.Point(12, 12);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(794, 441);
            this.menuPanel.TabIndex = 3;
            this.menuPanel.Click += new System.EventHandler(this.menuPanel_Click);
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // akustyczneButton
            // 
            this.akustyczneButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.akustyczneButton.Location = new System.Drawing.Point(94, 217);
            this.akustyczneButton.Name = "akustyczneButton";
            this.akustyczneButton.Size = new System.Drawing.Size(176, 95);
            this.akustyczneButton.TabIndex = 5;
            this.akustyczneButton.Text = "Test akustyczny";
            this.akustyczneButton.UseVisualStyleBackColor = true;
            this.akustyczneButton.Click += new System.EventHandler(this.akustyczneButton_Click);
            // 
            // wizualnyPrzycisk
            // 
            this.wizualnyPrzycisk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wizualnyPrzycisk.Location = new System.Drawing.Point(504, 217);
            this.wizualnyPrzycisk.Name = "wizualnyPrzycisk";
            this.wizualnyPrzycisk.Size = new System.Drawing.Size(176, 95);
            this.wizualnyPrzycisk.TabIndex = 4;
            this.wizualnyPrzycisk.Text = "Test wizualny";
            this.wizualnyPrzycisk.UseVisualStyleBackColor = true;
            this.wizualnyPrzycisk.Click += new System.EventHandler(this.wizualnyPrzycisk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(219, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testy psychomotoryczne";
            // 
            // wizualnyPanel
            // 
            this.wizualnyPanel.Controls.Add(this.resultChart);
            this.wizualnyPanel.Controls.Add(this.averageLabel);
            this.wizualnyPanel.Controls.Add(this.resultsTextBox);
            this.wizualnyPanel.Controls.Add(this.testButton);
            this.wizualnyPanel.Controls.Add(this.backButton);
            this.wizualnyPanel.Controls.Add(this.startstopButton);
            this.wizualnyPanel.Controls.Add(this.checkBox1);
            this.wizualnyPanel.Controls.Add(this.label2);
            this.wizualnyPanel.Location = new System.Drawing.Point(12, 12);
            this.wizualnyPanel.Name = "wizualnyPanel";
            this.wizualnyPanel.Size = new System.Drawing.Size(791, 438);
            this.wizualnyPanel.TabIndex = 6;
            // 
            // resultChart
            // 
            chartArea1.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resultChart.Legends.Add(legend1);
            this.resultChart.Location = new System.Drawing.Point(508, 189);
            this.resultChart.Name = "resultChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.resultChart.Series.Add(series1);
            this.resultChart.Size = new System.Drawing.Size(270, 182);
            this.resultChart.TabIndex = 7;
            this.resultChart.Text = "chart1";
            this.resultChart.Click += new System.EventHandler(this.resultChart_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.averageLabel.Location = new System.Drawing.Point(379, 392);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(65, 16);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.Text = "Średnia:";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(382, 189);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(120, 182);
            this.resultsTextBox.TabIndex = 5;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.Red;
            this.testButton.Location = new System.Drawing.Point(196, 189);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(180, 182);
            this.testButton.TabIndex = 4;
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(52, 283);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 88);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Wstecz";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // startstopButton
            // 
            this.startstopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startstopButton.Location = new System.Drawing.Point(52, 189);
            this.startstopButton.Name = "startstopButton";
            this.startstopButton.Size = new System.Drawing.Size(138, 88);
            this.startstopButton.TabIndex = 2;
            this.startstopButton.Text = "Start";
            this.startstopButton.UseVisualStyleBackColor = true;
            this.startstopButton.Click += new System.EventHandler(this.startstopButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(52, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Test próbny";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(748, 110);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // akustyczny
            // 
            this.akustyczny.Controls.Add(this.textBox1);
            this.akustyczny.Controls.Add(this.label3);
            this.akustyczny.Controls.Add(this.button1);
            this.akustyczny.Controls.Add(this.chart1);
            this.akustyczny.Controls.Add(this.checkBox2);
            this.akustyczny.Controls.Add(this.stop_acustic);
            this.akustyczny.Controls.Add(this.akustyczny_label);
            this.akustyczny.Controls.Add(this.Start_akust);
            this.akustyczny.Location = new System.Drawing.Point(12, 15);
            this.akustyczny.Name = "akustyczny";
            this.akustyczny.Size = new System.Drawing.Size(791, 438);
            this.akustyczny.TabIndex = 8;
            this.akustyczny.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Srednia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 217);
            this.button1.TabIndex = 6;
            this.button1.Text = "słysze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(528, 151);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(260, 225);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(52, 128);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "test próbny";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // stop_acustic
            // 
            this.stop_acustic.Location = new System.Drawing.Point(52, 274);
            this.stop_acustic.Name = "stop_acustic";
            this.stop_acustic.Size = new System.Drawing.Size(126, 100);
            this.stop_acustic.TabIndex = 2;
            this.stop_acustic.Text = "Wstecz";
            this.stop_acustic.UseVisualStyleBackColor = true;
            this.stop_acustic.Click += new System.EventHandler(this.stop_acustic_Click);
            // 
            // akustyczny_label
            // 
            this.akustyczny_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.akustyczny_label.Location = new System.Drawing.Point(146, 11);
            this.akustyczny_label.Name = "akustyczny_label";
            this.akustyczny_label.Size = new System.Drawing.Size(482, 110);
            this.akustyczny_label.TabIndex = 1;
            this.akustyczny_label.Text = resources.GetString("akustyczny_label.Text");
            // 
            // Start_akust
            // 
            this.Start_akust.Location = new System.Drawing.Point(52, 151);
            this.Start_akust.Name = "Start_akust";
            this.Start_akust.Size = new System.Drawing.Size(126, 101);
            this.Start_akust.TabIndex = 0;
            this.Start_akust.Text = "Start";
            this.Start_akust.UseVisualStyleBackColor = true;
            this.Start_akust.Click += new System.EventHandler(this.Start_akust_Click);
            // 
            // testTimer
            // 
            this.testTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 151);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 217);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 463);
            this.Controls.Add(this.akustyczny);
            this.Controls.Add(this.wizualnyPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.wizualnyPanel.ResumeLayout(false);
            this.wizualnyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            this.akustyczny.ResumeLayout(false);
            this.akustyczny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wizualnyPrzycisk;
        private System.Windows.Forms.Button akustyczneButton;
        private System.Windows.Forms.Panel wizualnyPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button startstopButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
        private System.Windows.Forms.Panel akustyczny;
        private System.Windows.Forms.Button Start_akust;
        private System.Windows.Forms.Label akustyczny_label;
        private System.Windows.Forms.Button stop_acustic;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

