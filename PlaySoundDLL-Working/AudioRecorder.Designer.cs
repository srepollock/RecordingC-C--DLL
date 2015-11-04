namespace PlaySoundDLL_Working
{
    partial class AudioRecorder
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
            this.ButtonPlanel = new System.Windows.Forms.Panel();
            this.StopPlayingButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.StopRecordButton = new System.Windows.Forms.Button();
            this.RecordButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sampleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonPlanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPlanel
            // 
            this.ButtonPlanel.Controls.Add(this.StopPlayingButton);
            this.ButtonPlanel.Controls.Add(this.PlayButton);
            this.ButtonPlanel.Controls.Add(this.StopRecordButton);
            this.ButtonPlanel.Controls.Add(this.RecordButton);
            this.ButtonPlanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPlanel.Location = new System.Drawing.Point(3, 3);
            this.ButtonPlanel.Name = "ButtonPlanel";
            this.ButtonPlanel.Size = new System.Drawing.Size(443, 94);
            this.ButtonPlanel.TabIndex = 0;
            // 
            // StopPlayingButton
            // 
            this.StopPlayingButton.Location = new System.Drawing.Point(226, 38);
            this.StopPlayingButton.Name = "StopPlayingButton";
            this.StopPlayingButton.Size = new System.Drawing.Size(75, 23);
            this.StopPlayingButton.TabIndex = 3;
            this.StopPlayingButton.Text = "Stop Playing";
            this.StopPlayingButton.UseVisualStyleBackColor = true;
            this.StopPlayingButton.Click += new System.EventHandler(this.StopPlayingButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(145, 38);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopRecordButton
            // 
            this.StopRecordButton.Location = new System.Drawing.Point(226, 9);
            this.StopRecordButton.Name = "StopRecordButton";
            this.StopRecordButton.Size = new System.Drawing.Size(75, 23);
            this.StopRecordButton.TabIndex = 1;
            this.StopRecordButton.Text = "Stop Recording";
            this.StopRecordButton.UseVisualStyleBackColor = true;
            this.StopRecordButton.Click += new System.EventHandler(this.StopRecordButton_Click);
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(145, 9);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(75, 23);
            this.RecordButton.TabIndex = 0;
            this.RecordButton.Text = "Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonPlanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 350);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sampleChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 244);
            this.panel1.TabIndex = 1;
            // 
            // sampleChart
            // 
            chartArea1.Name = "ChartArea1";
            this.sampleChart.ChartAreas.Add(chartArea1);
            this.sampleChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.sampleChart.Legends.Add(legend1);
            this.sampleChart.Location = new System.Drawing.Point(0, 0);
            this.sampleChart.Name = "sampleChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.sampleChart.Series.Add(series1);
            this.sampleChart.Size = new System.Drawing.Size(443, 244);
            this.sampleChart.TabIndex = 0;
            this.sampleChart.Text = "chart1";
            // 
            // AudioRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AudioRecorder";
            this.Text = "Audio Recorder";
            this.ButtonPlanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPlanel;
        private System.Windows.Forms.Button StopPlayingButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button StopRecordButton;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart sampleChart;
    }
}

