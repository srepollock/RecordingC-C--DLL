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
            this.button1 = new System.Windows.Forms.Button();
            this.stopRecButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopPlayButton = new System.Windows.Forms.Button();
            this.recButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.stopRecButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.stopPlayButton);
            this.panel1.Controls.Add(this.recButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 388);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopRecButton
            // 
            this.stopRecButton.Location = new System.Drawing.Point(268, 63);
            this.stopRecButton.Margin = new System.Windows.Forms.Padding(6);
            this.stopRecButton.Name = "stopRecButton";
            this.stopRecButton.Size = new System.Drawing.Size(183, 42);
            this.stopRecButton.TabIndex = 3;
            this.stopRecButton.Text = "Stop Recording";
            this.stopRecButton.UseVisualStyleBackColor = true;
            this.stopRecButton.Click += new System.EventHandler(this.stopRecButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(57, 157);
            this.playButton.Margin = new System.Windows.Forms.Padding(6);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(183, 42);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopPlayButton
            // 
            this.stopPlayButton.Location = new System.Drawing.Point(268, 157);
            this.stopPlayButton.Margin = new System.Windows.Forms.Padding(6);
            this.stopPlayButton.Name = "stopPlayButton";
            this.stopPlayButton.Size = new System.Drawing.Size(183, 42);
            this.stopPlayButton.TabIndex = 1;
            this.stopPlayButton.Text = "Stop Playing";
            this.stopPlayButton.UseVisualStyleBackColor = true;
            this.stopPlayButton.Click += new System.EventHandler(this.stopPlayButton_Click);
            // 
            // recButton
            // 
            this.recButton.Location = new System.Drawing.Point(57, 63);
            this.recButton.Margin = new System.Windows.Forms.Padding(6);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(183, 42);
            this.recButton.TabIndex = 0;
            this.recButton.Text = "Record";
            this.recButton.UseVisualStyleBackColor = true;
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Volume Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Volume Down";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RecordingCSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

