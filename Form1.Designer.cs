namespace OS_SCHEDULER
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
            this.components = new System.ComponentModel.Container();
            this.graphCont = new ZedGraph.ZedGraphControl();
            this.processBox = new System.Windows.Forms.ListBox();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.fcfsRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.sjfRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.psjfRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.prRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.pprRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.rrRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.pCreateBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.saveProcess = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.quantaTBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.doPlot = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.avgTimeLabel = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // graphCont
            // 
            this.graphCont.Location = new System.Drawing.Point(12, 444);
            this.graphCont.Name = "graphCont";
            this.graphCont.ScrollGrace = 0D;
            this.graphCont.ScrollMaxX = 0D;
            this.graphCont.ScrollMaxY = 0D;
            this.graphCont.ScrollMaxY2 = 0D;
            this.graphCont.ScrollMinX = 0D;
            this.graphCont.ScrollMinY = 0D;
            this.graphCont.ScrollMinY2 = 0D;
            this.graphCont.Size = new System.Drawing.Size(854, 315);
            this.graphCont.TabIndex = 1;
            this.graphCont.UseExtendedPrintDialog = true;
            // 
            // processBox
            // 
            this.processBox.BackColor = System.Drawing.Color.White;
            this.processBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processBox.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.processBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.processBox.FormattingEnabled = true;
            this.processBox.ItemHeight = 19;
            this.processBox.Location = new System.Drawing.Point(548, 220);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(319, 171);
            this.processBox.TabIndex = 2;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Enabled = false;
            this.materialFlatButton5.Location = new System.Drawing.Point(12, 75);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(125, 36);
            this.materialFlatButton5.TabIndex = 8;
            this.materialFlatButton5.Text = "Scheduler type";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Enabled = false;
            this.materialFlatButton1.Location = new System.Drawing.Point(13, 252);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(278, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Name ; burst ; arrival time ; priority;";
            this.materialFlatButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // fcfsRadio
            // 
            this.fcfsRadio.AutoSize = true;
            this.fcfsRadio.Depth = 0;
            this.fcfsRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.fcfsRadio.Location = new System.Drawing.Point(13, 117);
            this.fcfsRadio.Margin = new System.Windows.Forms.Padding(0);
            this.fcfsRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fcfsRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.fcfsRadio.Name = "fcfsRadio";
            this.fcfsRadio.Ripple = true;
            this.fcfsRadio.Size = new System.Drawing.Size(61, 30);
            this.fcfsRadio.TabIndex = 9;
            this.fcfsRadio.TabStop = true;
            this.fcfsRadio.Tag = "FCFS";
            this.fcfsRadio.Text = "FCFS";
            this.fcfsRadio.UseVisualStyleBackColor = true;
            this.fcfsRadio.CheckedChanged += new System.EventHandler(this.fcfsRadio_CheckedChanged);
            // 
            // sjfRadio
            // 
            this.sjfRadio.AutoSize = true;
            this.sjfRadio.Depth = 0;
            this.sjfRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.sjfRadio.Location = new System.Drawing.Point(91, 117);
            this.sjfRadio.Margin = new System.Windows.Forms.Padding(0);
            this.sjfRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sjfRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.sjfRadio.Name = "sjfRadio";
            this.sjfRadio.Ripple = true;
            this.sjfRadio.Size = new System.Drawing.Size(52, 30);
            this.sjfRadio.TabIndex = 9;
            this.sjfRadio.TabStop = true;
            this.sjfRadio.Tag = "SJF";
            this.sjfRadio.Text = "SJF";
            this.sjfRadio.UseVisualStyleBackColor = true;
            this.sjfRadio.CheckedChanged += new System.EventHandler(this.sjfRadio_CheckedChanged);
            // 
            // psjfRadio
            // 
            this.psjfRadio.AutoSize = true;
            this.psjfRadio.Depth = 0;
            this.psjfRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.psjfRadio.Location = new System.Drawing.Point(163, 117);
            this.psjfRadio.Margin = new System.Windows.Forms.Padding(0);
            this.psjfRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.psjfRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.psjfRadio.Name = "psjfRadio";
            this.psjfRadio.Ripple = true;
            this.psjfRadio.Size = new System.Drawing.Size(68, 30);
            this.psjfRadio.TabIndex = 9;
            this.psjfRadio.TabStop = true;
            this.psjfRadio.Tag = "PSJFS";
            this.psjfRadio.Text = "P. SJF";
            this.psjfRadio.UseVisualStyleBackColor = true;
            this.psjfRadio.CheckedChanged += new System.EventHandler(this.psjfRadio_CheckedChanged);
            // 
            // prRadio
            // 
            this.prRadio.AutoSize = true;
            this.prRadio.Depth = 0;
            this.prRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.prRadio.Location = new System.Drawing.Point(251, 117);
            this.prRadio.Margin = new System.Windows.Forms.Padding(0);
            this.prRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.prRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.prRadio.Name = "prRadio";
            this.prRadio.Ripple = true;
            this.prRadio.Size = new System.Drawing.Size(73, 30);
            this.prRadio.TabIndex = 9;
            this.prRadio.TabStop = true;
            this.prRadio.Tag = "pr";
            this.prRadio.Text = "Priority";
            this.prRadio.UseVisualStyleBackColor = true;
            this.prRadio.CheckedChanged += new System.EventHandler(this.prRadio_CheckedChanged);
            // 
            // pprRadio
            // 
            this.pprRadio.AutoSize = true;
            this.pprRadio.Depth = 0;
            this.pprRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.pprRadio.Location = new System.Drawing.Point(339, 117);
            this.pprRadio.Margin = new System.Windows.Forms.Padding(0);
            this.pprRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pprRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.pprRadio.Name = "pprRadio";
            this.pprRadio.Ripple = true;
            this.pprRadio.Size = new System.Drawing.Size(89, 30);
            this.pprRadio.TabIndex = 9;
            this.pprRadio.TabStop = true;
            this.pprRadio.Tag = "ppr";
            this.pprRadio.Text = "P. Priority";
            this.pprRadio.UseVisualStyleBackColor = true;
            this.pprRadio.CheckedChanged += new System.EventHandler(this.pprRadio_CheckedChanged);
            // 
            // rrRadio
            // 
            this.rrRadio.AutoSize = true;
            this.rrRadio.Depth = 0;
            this.rrRadio.Font = new System.Drawing.Font("Roboto", 10F);
            this.rrRadio.Location = new System.Drawing.Point(442, 117);
            this.rrRadio.Margin = new System.Windows.Forms.Padding(0);
            this.rrRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rrRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.rrRadio.Name = "rrRadio";
            this.rrRadio.Ripple = true;
            this.rrRadio.Size = new System.Drawing.Size(107, 30);
            this.rrRadio.TabIndex = 9;
            this.rrRadio.TabStop = true;
            this.rrRadio.Tag = "rr";
            this.rrRadio.Text = "Round Robin";
            this.rrRadio.UseVisualStyleBackColor = true;
            this.rrRadio.CheckedChanged += new System.EventHandler(this.rrRadio_CheckedChanged);
            // 
            // pCreateBox
            // 
            this.pCreateBox.Depth = 0;
            this.pCreateBox.Hint = "Process info separated by \";\"";
            this.pCreateBox.Location = new System.Drawing.Point(13, 220);
            this.pCreateBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pCreateBox.Name = "pCreateBox";
            this.pCreateBox.PasswordChar = '\0';
            this.pCreateBox.SelectedText = "";
            this.pCreateBox.SelectionLength = 0;
            this.pCreateBox.SelectionStart = 0;
            this.pCreateBox.Size = new System.Drawing.Size(212, 23);
            this.pCreateBox.TabIndex = 10;
            this.pCreateBox.UseSystemPasswordChar = false;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Enabled = false;
            this.materialFlatButton2.Location = new System.Drawing.Point(13, 175);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(115, 36);
            this.materialFlatButton2.TabIndex = 8;
            this.materialFlatButton2.Text = "Add a process";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // saveProcess
            // 
            this.saveProcess.Depth = 0;
            this.saveProcess.Location = new System.Drawing.Point(13, 351);
            this.saveProcess.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveProcess.Name = "saveProcess";
            this.saveProcess.Primary = true;
            this.saveProcess.Size = new System.Drawing.Size(212, 36);
            this.saveProcess.TabIndex = 11;
            this.saveProcess.Text = "Add Process";
            this.saveProcess.UseVisualStyleBackColor = true;
            this.saveProcess.Click += new System.EventHandler(this.saveProcess_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Enabled = false;
            this.materialFlatButton3.Location = new System.Drawing.Point(13, 300);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(218, 36);
            this.materialFlatButton3.TabIndex = 8;
            this.materialFlatButton3.Text = "Leave any unused info clear\r\n\r\n";
            this.materialFlatButton3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Enabled = false;
            this.materialFlatButton6.Location = new System.Drawing.Point(533, 175);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(151, 36);
            this.materialFlatButton6.TabIndex = 8;
            this.materialFlatButton6.Text = "Created Processes";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // quantaTBox
            // 
            this.quantaTBox.Depth = 0;
            this.quantaTBox.Enabled = false;
            this.quantaTBox.Hint = "Enter Q";
            this.quantaTBox.Location = new System.Drawing.Point(326, 220);
            this.quantaTBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.quantaTBox.Name = "quantaTBox";
            this.quantaTBox.PasswordChar = '\0';
            this.quantaTBox.SelectedText = "";
            this.quantaTBox.SelectionLength = 0;
            this.quantaTBox.SelectionStart = 0;
            this.quantaTBox.Size = new System.Drawing.Size(102, 23);
            this.quantaTBox.TabIndex = 10;
            this.quantaTBox.UseSystemPasswordChar = false;
            // 
            // doPlot
            // 
            this.doPlot.Depth = 0;
            this.doPlot.Location = new System.Drawing.Point(13, 402);
            this.doPlot.MouseState = MaterialSkin.MouseState.HOVER;
            this.doPlot.Name = "doPlot";
            this.doPlot.Primary = true;
            this.doPlot.Size = new System.Drawing.Size(90, 36);
            this.doPlot.TabIndex = 11;
            this.doPlot.Text = "Plot";
            this.doPlot.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Enabled = false;
            this.materialFlatButton4.Location = new System.Drawing.Point(326, 175);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(79, 36);
            this.materialFlatButton4.TabIndex = 8;
            this.materialFlatButton4.Text = "Quantum";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // avgTimeLabel
            // 
            this.avgTimeLabel.AutoSize = true;
            this.avgTimeLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.avgTimeLabel.Depth = 0;
            this.avgTimeLabel.Enabled = false;
            this.avgTimeLabel.Location = new System.Drawing.Point(533, 399);
            this.avgTimeLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.avgTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.avgTimeLabel.Name = "avgTimeLabel";
            this.avgTimeLabel.Primary = false;
            this.avgTimeLabel.Size = new System.Drawing.Size(112, 36);
            this.avgTimeLabel.TabIndex = 8;
            this.avgTimeLabel.Text = "Average Time: ";
            this.avgTimeLabel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 780);
            this.Controls.Add(this.doPlot);
            this.Controls.Add(this.saveProcess);
            this.Controls.Add(this.quantaTBox);
            this.Controls.Add(this.pCreateBox);
            this.Controls.Add(this.rrRadio);
            this.Controls.Add(this.psjfRadio);
            this.Controls.Add(this.pprRadio);
            this.Controls.Add(this.sjfRadio);
            this.Controls.Add(this.prRadio);
            this.Controls.Add(this.fcfsRadio);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.avgTimeLabel);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.processBox);
            this.Controls.Add(this.graphCont);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "OS Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZedGraph.ZedGraphControl graphCont;
        private System.Windows.Forms.ListBox processBox;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRadioButton fcfsRadio;
        private MaterialSkin.Controls.MaterialRadioButton sjfRadio;
        private MaterialSkin.Controls.MaterialRadioButton psjfRadio;
        private MaterialSkin.Controls.MaterialRadioButton prRadio;
        private MaterialSkin.Controls.MaterialRadioButton pprRadio;
        private MaterialSkin.Controls.MaterialRadioButton rrRadio;
        private MaterialSkin.Controls.MaterialSingleLineTextField pCreateBox;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialRaisedButton saveProcess;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialSingleLineTextField quantaTBox;
        private MaterialSkin.Controls.MaterialRaisedButton doPlot;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton avgTimeLabel;
    }
}

