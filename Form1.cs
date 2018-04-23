using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;
//using ZedGraph;

namespace OS_SCHEDULER
{
    public partial class Form1 : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;

        static Color[] RandomColors = new Color[] {Color .DarkRed,Color.DarkSeaGreen,Color.DodgerBlue,Color.Goldenrod
        ,Color.Lavender,Color.Coral,Color.Firebrick,Color.LavenderBlush,Color.YellowGreen,Color.PeachPuff,Color.DarkViolet};

        Top simulator;

        Q rq;
        Func<Process, Process, bool> schedFunct;
        int quanta = -1;
        int colorIndex = 0;
        bool preEmpt = false;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink600, Primary.Pink700, Primary.Pink200, Accent.Blue700, TextShade.WHITE);
            CreateGraph(graphCont, "FCFS");
            rq = new Q(fcfsSched);
            //rq.addProcess(new Process(80, "p0", 0, 3));
            //rq.addProcess(new Process(20, "p1", 10, 1));
            //rq.addProcess(new Process(10, "p2", 10, 4));
            //rq.addProcess(new Process(20, "p3", 80, 5));
            //rq.addProcess(new Process(50, "p4", 85, 2));

            //rq.addProcess(new Process(8, "p1", 0, 2));
            //rq.addProcess(new Process(4, "p2", 1, 2));
            //rq.addProcess(new Process(9, "p3", 2, 2));
            //rq.addProcess(new Process(5, "p4", 3, 2));

            
            //rq.addProcess(new Process(10, "p1", 0, 3,Color.OrangeRed));
            //rq.addProcess(new Process(1, "p2", 0, 1, Color.Green));
            //rq.addProcess(new Process(2, "p3", 0, 4, Color.Blue));
            //rq.addProcess(new Process(1, "p4", 0, 5, Color.Brown));
            //rq.addProcess(new Process(5, "p5", 0, 2, Color.Purple));
            //Top simulator_rr = new Top(graphCont,rq, fcfsSched, false);
            //simulator_rr.sim();


            doPlot.Click += drawResult;

            fcfsRadio.Click += clearPq;
            sjfRadio.Click += clearPq;
            psjfRadio.Click += clearPq;
            prRadio.Click += clearPq;
            pprRadio.Click += clearPq;
            rrRadio.Click += clearPq;
        }

        private void clearPq(object sender, EventArgs e)
        {
            rq = new Q(fcfsSched);
            processBox.Items.Clear();
            var p = graphCont.GraphPane;
            p.CurveList.Clear();
        }

        private void drawResult(object sender, EventArgs e)
        {
            if (quantaTBox.Enabled)
                try
                {
                    quanta = Convert.ToInt16(quantaTBox.Text);
                }
                catch 
                {

                    MetroFramework.MetroMessageBox.Show(this, "Error Quantum value");
                    return;
                }
            
            try
            {
                simulator = new Top(graphCont, rq, schedFunct, preEmpt, quanta);
                simulator.sim(avgTimeLabel);
            }
            catch 
            {

                MetroFramework.MetroMessageBox.Show(this, "Make sure to enter processes");
            }

        }



        private void CreateGraph(ZedGraphControl zg1,string schedType)
        {
            GraphPane myPane = zg1.GraphPane; //Reference al graph pane bta3t al object

            
            myPane.Title.Text = "Process Gantt Chart"; //Zabt al title
            myPane.YAxis.Title.Text = "Scheduler Type"; //Zabt al title bta3y al yAxis
            myPane.XAxis.Title.Text = "Time";  //Zabt al title bta3y al XAxis
            string[] labels = { schedType, "Average time" };
            //Pass al string aly httktb t7t al bar
            //Law 3ndk aktr mn bar 3ayz trsmhom f nfs l wa2t, zawd al strings kolaha fl array labels de

            myPane.BarSettings.Type = BarType.Stack;  //Set al bar type
            myPane.BarSettings.ClusterScaleWidth = 1.5;  //zabt al bar width

            myPane.YAxis.Scale.TextLabels = labels;     //7ot al strings 3ala al y-Axis
            myPane.YAxis.Type = ZedGraph.AxisType.Text; 
            myPane.BarSettings.Base = BarBase.Y;        //5alih yrsm bl 3ard
            zg1.AxisChange();                           //Rescale ama no2ta geda ttrsm
            zg1.Refresh();
        }

        private void stackBar(ZedGraphControl zg1,string labelName,int val,Color clr) 
        {
            ZedGraph.PointPairList listStack = new ZedGraph.PointPairList();
            listStack.Add(val,0);
            //listC.Add(date2, 12);

            BarItem barC = zg1.GraphPane.AddBar(labelName, listStack, clr);
            barC.Bar.Fill = new Fill(clr);
            zg1.AxisChange(); // Update graph.
            zg1.Refresh();
        }

        private bool fcfsSched(Process x,Process y)
        {
            return x.arrivalTime < y.arrivalTime;
        }

        private bool sjfSched(Process x, Process y)
        {
            return x.burst <= y.burst;
        }

        private bool prioritySched(Process x, Process y)
        {
            return x.priority <= y.priority;
        }

        private void fcfsRadio_CheckedChanged(object sender, EventArgs e)
        {
            schedFunct = fcfsSched;
            quanta = -1;
            preEmpt = false;
            quantaTBox.Enabled = false;
        }

        private void sjfRadio_CheckedChanged(object sender, EventArgs e)
        {
            schedFunct = sjfSched;
            preEmpt = false;
            quanta = -1;
            quantaTBox.Enabled = false;
        }

        private void psjfRadio_CheckedChanged(object sender, EventArgs e)
        {
            schedFunct = sjfSched;
            preEmpt = true;
            quanta = -1;
            quantaTBox.Enabled = false;
        }

        private void prRadio_CheckedChanged(object sender, EventArgs e)
        {
            schedFunct = prioritySched;
            preEmpt = false;
            quanta = -1;
            quantaTBox.Enabled = false;
        }

        private void pprRadio_CheckedChanged(object sender, EventArgs e)
        {
            schedFunct = prioritySched;
            preEmpt = true;
            quanta = -1;
            quantaTBox.Enabled = false;
        }

        private void rrRadio_CheckedChanged(object sender, EventArgs e)
        {
            schedFunct = fcfsSched;
            preEmpt = false;
            quantaTBox.Enabled = true;
        }

        private void saveProcess_Click(object sender, EventArgs e)
        {
            string[] processArg = pCreateBox.Text.Split(';');
            try
            {
                var fo = processArg[3];
            }
            catch 
            {
                MetroFramework.MetroMessageBox.Show(this, "You are missing an argument\nMaybe you should add a semicolon!");
                return;

            }
            if (processArg[3] == "" && (!prRadio.Checked && !pprRadio.Checked))
                processArg[3] = "0";
            else if(processArg[3] == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter the process priority number");
                return;
            }
            try
            {
                var p2Insert = new Process(Convert.ToInt16(processArg[1]), processArg[0], Convert.ToInt16(processArg[2]), Convert.ToInt16(processArg[3]), RandomColors[colorIndex]);
                rq.addProcess(p2Insert);
                colorIndex = (colorIndex + 1) % 10;
                processBox.Items.Add(p2Insert.name + 
                    ", Burst: " + p2Insert.burst.ToString() + ", Arrives at: " + p2Insert.arrivalTime.ToString() + ", Priority: "+p2Insert.priority.ToString());
            }
            catch 
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter the process in the correct form");
            }
          
        }
    }
}
