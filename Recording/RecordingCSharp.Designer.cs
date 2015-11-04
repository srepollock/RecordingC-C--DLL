namespace Recording
{
    partial class RecordingCSharp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopRecButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopPlayButton = new System.Windows.Forms.Button();
            this.recButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stopRecButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.stopPlayButton);
            this.panel1.Controls.Add(this.recButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 144);
            this.panel1.TabIndex = 0;
            // 
            // stopRecButton
            // 
            this.stopRecButton.Location = new System.Drawing.Point(146, 34);
            this.stopRecButton.Name = "stopRecButton";
            this.stopRecButton.Size = new System.Drawing.Size(100, 23);
            this.stopRecButton.TabIndex = 3;
            this.stopRecButton.Text = "Stop Recording";
            this.stopRecButton.UseVisualStyleBackColor = true;
            this.stopRecButton.Click += new System.EventHandler(this.stopRecButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(31, 85);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopPlayButton
            // 
            this.stopPlayButton.Location = new System.Drawing.Point(146, 85);
            this.stopPlayButton.Name = "stopPlayButton";
            this.stopPlayButton.Size = new System.Drawing.Size(100, 23);
            this.stopPlayButton.TabIndex = 1;
            this.stopPlayButton.Text = "Stop Playing";
            this.stopPlayButton.UseVisualStyleBackColor = true;
            this.stopPlayButton.Click += new System.EventHandler(this.stopPlayButton_Click);
            // 
            // recButton
            // 
            this.recButton.Location = new System.Drawing.Point(31, 34);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(100, 23);
            this.recButton.TabIndex = 0;
            this.recButton.Text = "Record";
            this.recButton.UseVisualStyleBackColor = true;
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // RecordingCSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecordingCSharp";
            this.Text = "Recording C#";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopRecButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopPlayButton;
        private System.Windows.Forms.Button recButton;
    }
}

