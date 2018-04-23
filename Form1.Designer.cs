namespace OS_MEMORY_ASSIGNMENT
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
            this.zedGraphObj = new ZedGraph.ZedGraphControl();
            this.taskList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deallocBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.holeSizeTB = new System.Windows.Forms.TextBox();
            this.processSizeTB = new System.Windows.Forms.TextBox();
            this.holeStartAddressTB = new System.Windows.Forms.TextBox();
            this.processNameTB = new System.Windows.Forms.TextBox();
            this.addHole = new System.Windows.Forms.Button();
            this.addProcess = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstFitSel = new System.Windows.Forms.RadioButton();
            this.bestFitSel = new System.Windows.Forms.RadioButton();
            this.compactionCheck = new System.Windows.Forms.CheckBox();
            this.worstFitSel = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.simLogTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // zedGraphObj
            // 
            this.zedGraphObj.Location = new System.Drawing.Point(12, 142);
            this.zedGraphObj.Name = "zedGraphObj";
            this.zedGraphObj.ScrollGrace = 0D;
            this.zedGraphObj.ScrollMaxX = 0D;
            this.zedGraphObj.ScrollMaxY = 0D;
            this.zedGraphObj.ScrollMaxY2 = 0D;
            this.zedGraphObj.ScrollMinX = 0D;
            this.zedGraphObj.ScrollMinY = 0D;
            this.zedGraphObj.ScrollMinY2 = 0D;
            this.zedGraphObj.Size = new System.Drawing.Size(440, 481);
            this.zedGraphObj.TabIndex = 0;
            this.zedGraphObj.UseExtendedPrintDialog = true;
            // 
            // taskList
            // 
            this.taskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskList.FormattingEnabled = true;
            this.taskList.ItemHeight = 16;
            this.taskList.Location = new System.Drawing.Point(458, 108);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(245, 212);
            this.taskList.TabIndex = 3;
            this.taskList.SelectedIndexChanged += new System.EventHandler(this.taskList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task Manager";
            // 
            // deallocBut
            // 
            this.deallocBut.Enabled = false;
            this.deallocBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deallocBut.Location = new System.Drawing.Point(458, 326);
            this.deallocBut.Name = "deallocBut";
            this.deallocBut.Size = new System.Drawing.Size(245, 42);
            this.deallocBut.TabIndex = 5;
            this.deallocBut.Text = "De-Allocate Process";
            this.deallocBut.UseVisualStyleBackColor = true;
            this.deallocBut.Click += new System.EventHandler(this.deallocBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Memory View";
            // 
            // holeSizeTB
            // 
            this.holeSizeTB.Location = new System.Drawing.Point(594, 571);
            this.holeSizeTB.Name = "holeSizeTB";
            this.holeSizeTB.Size = new System.Drawing.Size(100, 20);
            this.holeSizeTB.TabIndex = 16;
            // 
            // processSizeTB
            // 
            this.processSizeTB.Location = new System.Drawing.Point(458, 571);
            this.processSizeTB.Name = "processSizeTB";
            this.processSizeTB.Size = new System.Drawing.Size(100, 20);
            this.processSizeTB.TabIndex = 17;
            // 
            // holeStartAddressTB
            // 
            this.holeStartAddressTB.Location = new System.Drawing.Point(594, 529);
            this.holeStartAddressTB.Name = "holeStartAddressTB";
            this.holeStartAddressTB.Size = new System.Drawing.Size(100, 20);
            this.holeStartAddressTB.TabIndex = 18;
            // 
            // processNameTB
            // 
            this.processNameTB.Location = new System.Drawing.Point(458, 529);
            this.processNameTB.Name = "processNameTB";
            this.processNameTB.Size = new System.Drawing.Size(100, 20);
            this.processNameTB.TabIndex = 19;
            // 
            // addHole
            // 
            this.addHole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHole.Location = new System.Drawing.Point(594, 597);
            this.addHole.Name = "addHole";
            this.addHole.Size = new System.Drawing.Size(100, 23);
            this.addHole.TabIndex = 14;
            this.addHole.Text = "Add hole";
            this.addHole.UseVisualStyleBackColor = true;
            this.addHole.Click += new System.EventHandler(this.addHole_Click);
            // 
            // addProcess
            // 
            this.addProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProcess.Location = new System.Drawing.Point(458, 597);
            this.addProcess.Name = "addProcess";
            this.addProcess.Size = new System.Drawing.Size(98, 23);
            this.addProcess.TabIndex = 15;
            this.addProcess.Text = "Add Process";
            this.addProcess.UseVisualStyleBackColor = true;
            this.addProcess.Click += new System.EventHandler(this.addProcess_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hole size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Process Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hole start address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Process Name";
            // 
            // firstFitSel
            // 
            this.firstFitSel.AutoSize = true;
            this.firstFitSel.Checked = true;
            this.firstFitSel.Location = new System.Drawing.Point(12, 108);
            this.firstFitSel.Name = "firstFitSel";
            this.firstFitSel.Size = new System.Drawing.Size(58, 17);
            this.firstFitSel.TabIndex = 20;
            this.firstFitSel.TabStop = true;
            this.firstFitSel.Text = "First Fit";
            this.firstFitSel.UseVisualStyleBackColor = true;
            this.firstFitSel.CheckedChanged += new System.EventHandler(this.firstFitSel_CheckedChanged);
            // 
            // bestFitSel
            // 
            this.bestFitSel.AutoSize = true;
            this.bestFitSel.Location = new System.Drawing.Point(76, 108);
            this.bestFitSel.Name = "bestFitSel";
            this.bestFitSel.Size = new System.Drawing.Size(60, 17);
            this.bestFitSel.TabIndex = 20;
            this.bestFitSel.Text = "Best Fit";
            this.bestFitSel.UseVisualStyleBackColor = true;
            this.bestFitSel.CheckedChanged += new System.EventHandler(this.bestFitSel_CheckedChanged);
            // 
            // compactionCheck
            // 
            this.compactionCheck.AutoSize = true;
            this.compactionCheck.Location = new System.Drawing.Point(225, 108);
            this.compactionCheck.Name = "compactionCheck";
            this.compactionCheck.Size = new System.Drawing.Size(82, 17);
            this.compactionCheck.TabIndex = 21;
            this.compactionCheck.Text = "Compaction";
            this.compactionCheck.UseVisualStyleBackColor = true;
            this.compactionCheck.CheckedChanged += new System.EventHandler(this.compactionCheck_CheckedChanged);
            // 
            // worstFitSel
            // 
            this.worstFitSel.AutoSize = true;
            this.worstFitSel.Location = new System.Drawing.Point(142, 108);
            this.worstFitSel.Name = "worstFitSel";
            this.worstFitSel.Size = new System.Drawing.Size(67, 17);
            this.worstFitSel.TabIndex = 20;
            this.worstFitSel.Text = "Worst Fit";
            this.worstFitSel.UseVisualStyleBackColor = true;
            this.worstFitSel.CheckedChanged += new System.EventHandler(this.worstFitSel_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Log";
            // 
            // simLogTextBox
            // 
            this.simLogTextBox.Location = new System.Drawing.Point(458, 391);
            this.simLogTextBox.Name = "simLogTextBox";
            this.simLogTextBox.ReadOnly = true;
            this.simLogTextBox.Size = new System.Drawing.Size(245, 115);
            this.simLogTextBox.TabIndex = 22;
            this.simLogTextBox.Text = "Simulation Started \n\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 635);
            this.Controls.Add(this.simLogTextBox);
            this.Controls.Add(this.compactionCheck);
            this.Controls.Add(this.worstFitSel);
            this.Controls.Add(this.bestFitSel);
            this.Controls.Add(this.firstFitSel);
            this.Controls.Add(this.holeSizeTB);
            this.Controls.Add(this.processSizeTB);
            this.Controls.Add(this.holeStartAddressTB);
            this.Controls.Add(this.processNameTB);
            this.Controls.Add(this.addHole);
            this.Controls.Add(this.addProcess);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deallocBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.zedGraphObj);
            this.Name = "Form1";
            this.Text = "OS Assignment 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphObj;
        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deallocBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox holeSizeTB;
        private System.Windows.Forms.TextBox processSizeTB;
        private System.Windows.Forms.TextBox holeStartAddressTB;
        private System.Windows.Forms.TextBox processNameTB;
        private System.Windows.Forms.Button addHole;
        private System.Windows.Forms.Button addProcess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton firstFitSel;
        private System.Windows.Forms.RadioButton bestFitSel;
        private System.Windows.Forms.CheckBox compactionCheck;
        private System.Windows.Forms.RadioButton worstFitSel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox simLogTextBox;
    }
}

