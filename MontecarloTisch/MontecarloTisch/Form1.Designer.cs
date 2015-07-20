namespace MontecarloTisch
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartButton = new System.Windows.Forms.Button();
            this.Wiederholungen = new System.Windows.Forms.NumericUpDown();
            this.wdhLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Personen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Startposition = new System.Windows.Forms.NumericUpDown();
            this.zufallsButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Wiederholungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Startposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(656, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Wiederholungen
            // 
            this.Wiederholungen.Location = new System.Drawing.Point(106, 14);
            this.Wiederholungen.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Wiederholungen.Name = "Wiederholungen";
            this.Wiederholungen.Size = new System.Drawing.Size(82, 20);
            this.Wiederholungen.TabIndex = 1;
            this.Wiederholungen.Value = new decimal(new int[] {
            1337,
            0,
            0,
            0});
            // 
            // wdhLabel
            // 
            this.wdhLabel.AutoSize = true;
            this.wdhLabel.Location = new System.Drawing.Point(12, 17);
            this.wdhLabel.Name = "wdhLabel";
            this.wdhLabel.Size = new System.Drawing.Size(88, 13);
            this.wdhLabel.TabIndex = 2;
            this.wdhLabel.Text = "Wiederholungen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personen:";
            // 
            // Personen
            // 
            this.Personen.Location = new System.Drawing.Point(278, 14);
            this.Personen.Name = "Personen";
            this.Personen.Size = new System.Drawing.Size(82, 20);
            this.Personen.TabIndex = 4;
            this.Personen.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Startposition:";
            // 
            // Startposition
            // 
            this.Startposition.Location = new System.Drawing.Point(466, 14);
            this.Startposition.Name = "Startposition";
            this.Startposition.Size = new System.Drawing.Size(82, 20);
            this.Startposition.TabIndex = 6;
            this.Startposition.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // zufallsButton
            // 
            this.zufallsButton.Location = new System.Drawing.Point(552, 13);
            this.zufallsButton.Name = "zufallsButton";
            this.zufallsButton.Size = new System.Drawing.Size(47, 23);
            this.zufallsButton.TabIndex = 7;
            this.zufallsButton.Text = "Zufall";
            this.zufallsButton.UseVisualStyleBackColor = true;
            this.zufallsButton.Click += new System.EventHandler(this.zufallsButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 80);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(719, 474);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 51);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(716, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 566);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.zufallsButton);
            this.Controls.Add(this.Startposition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Personen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wdhLabel);
            this.Controls.Add(this.Wiederholungen);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Montecarlo-Simulation: Wer bekommt den Kuchen als Letzter";
            ((System.ComponentModel.ISupportInitialize)(this.Wiederholungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Personen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Startposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown Wiederholungen;
        private System.Windows.Forms.Label wdhLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Personen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Startposition;
        private System.Windows.Forms.Button zufallsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}

