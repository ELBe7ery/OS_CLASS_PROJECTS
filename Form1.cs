using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using ZedGraph;

namespace OS_MEMORY_ASSIGNMENT
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        MemoryContainer uut;
        Func<MemoryLocation,MemoryLocation,bool> srt;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.Blue700, TextShade.WHITE);
            CreateGraph(zedGraphObj);
            uut = new MemoryContainer(worstFit, firstFit, zedGraphObj, simLogTextBox, taskList,true);
            srt = firstFit;
            //Just comment this out after testing 
            //  addHole(Starting Address, Size);

            //uut.addHole(20, 50);
            //uut.addHole(0, 5);
            //uut.addHole(6, 5);

            //uut.addHole(101, 500);
            //uut.addHole(602, 200);
            //uut.addHole(803, 300);
            //uut.addHole(1104, 600);

            //uut.addProcess("P1", 10);
            //uut.addProcess("P2", 30);
            //uut.addProcess("P3", 20);

            //uut.addProcess("P3", 112);
            //uut.addProcess("P4", 426);

            //uut.addHole(700, 40);
            //uut.addHole(750, 200);

            //uut.addProcess("P1", 20);
            //uut.addProcess("P2", 40);
            //uut.addProcess("P3", 100);
            //uut.addProcess("P4", 600);
            //uut.addProcess("P5", 800);
            //uut.addProcess("P6", 80);
            //uut.addProcess("P7", 40);
            //uut.addProcess("P8", 50);

            //uut.addHole(0, 1);
            //uut.addHole(2, 2);
            //uut.addHole(5, 2);
            //uut.addProcess("P1", 5);



            //uut.addHole(0, 100);
            //uut.addHole(0, 100);
            //uut.addHole(0, 100);
            //uut.addHole(0, 100);
            //uut.addHole(0, 100);
            //uut.addHole(0, 100);

            //uut.addHole(54, 1);
            //uut.addHole(55, 1);
            //uut.addHole(56, 1);
            //uut.addHole(49, 1);
            //uut.addHole(53, 1);
            //uut.addHole(57, 1);
            //uut.addHole(102, 50);
            //uut.addHole(160, 51);

            //uut.addProcess("P2", 49);  //->should be at 50
            //uut.addProcess("P1", 89);  //->should be at 400
            //uut.update();
            //uut.update();
            uut.update();

        }

        private void CreateGraph(ZedGraphControl zg1)
        {
            GraphPane myPane = zg1.GraphPane; //Reference al graph pane bta3t al object
            myPane.YAxis.Scale.IsReverse = true;

            myPane.Title.Text = "Memory View"; //Zabt al title
            myPane.YAxis.Title.Text = "Address"; //Zabt al title bta3y al yAxis
            myPane.XAxis.Title.Text = "";  //Zabt al title bta3y al XAxis
            string[] labels = {"Main Memory" };
            //Pass al string aly httktb t7t al bar
            //Law 3ndk aktr mn bar 3ayz trsmhom f nfs l wa2t, zawd al strings kolaha fl array labels de

            myPane.BarSettings.Type = BarType.Stack;  //Set al bar type
            myPane.BarSettings.ClusterScaleWidth = 1.5;  //zabt al bar width

            myPane.XAxis.Scale.TextLabels = labels;     //7ot al strings 3ala al y-Axis
            myPane.XAxis.Type = ZedGraph.AxisType.Text;
            zg1.AxisChange();                           //Rescale ama no2ta geda ttrsm
            zg1.Refresh();
        }

        private void addProcess_Click(object sender, EventArgs e)
        {
            try
            {
                uut.addProcess(processNameTB.Text, int.Parse(processSizeTB.Text));
                uut.update();
            }
            catch 
            {

                MessageBox.Show("You didnt enter the size in a correct form!");
            }
            
        }

        private void addHole_Click(object sender, EventArgs e)
        {
            try
            {
                uut.addHole(int.Parse(holeStartAddressTB.Text), int.Parse(holeSizeTB.Text));
                uut.update();
            }
            catch 
            {

                MessageBox.Show("Check the input format for the hole you are adding");
            }

        }

        private void firstFitSel_CheckedChanged(object sender, EventArgs e)
        {
            clearGraph();
            srt = firstFit;
            uut = new MemoryContainer(srt, firstFit, zedGraphObj, simLogTextBox, taskList, compactionCheck.Checked);
            
        }
        private void bestFitSel_CheckedChanged(object sender, EventArgs e)
        {
            clearGraph();
            srt = bestFit;
            uut = new MemoryContainer(srt, firstFit, zedGraphObj, simLogTextBox, taskList, compactionCheck.Checked);
        }
        private void worstFitSel_CheckedChanged(object sender, EventArgs e)
        {
            clearGraph();
            srt = worstFit;
            uut = new MemoryContainer(srt, firstFit, zedGraphObj, simLogTextBox, taskList, compactionCheck.Checked);
        }

        private void compactionCheck_CheckedChanged(object sender, EventArgs e)
        {
            clearGraph();
            uut = new MemoryContainer(srt, firstFit, zedGraphObj, simLogTextBox, taskList,compactionCheck.Checked);
        }

        void clearGraph()
        {
            zedGraphObj.GraphPane.CurveList.Clear();
            zedGraphObj.GraphPane.AxisChange();
            zedGraphObj.Refresh();
            taskList.Items.Clear();
            simLogTextBox.Text = "Simulation Started\n\n";
        }

        bool firstFit(MemoryLocation lhs, MemoryLocation rhs)
        {
            return lhs.startAddress < rhs.startAddress;
        }

        bool bestFit(MemoryLocation lhs, MemoryLocation rhs)
        {
            return lhs.locSize < rhs.locSize;
        }

        bool worstFit(MemoryLocation lhs, MemoryLocation rhs)
        {
            return lhs.locSize > rhs.locSize;
        }


        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskList.SelectedIndex >= 0)
                deallocBut.Enabled = true;
            else
                deallocBut.Enabled = false;
        }

        private void deallocBut_Click(object sender, EventArgs e)
        {
            string toRemove = (string)taskList.SelectedItem;
            toRemove = toRemove.Substring(0, toRemove.IndexOf(' '));
            taskList.Items.RemoveAt(taskList.SelectedIndex);
            uut.removeProcess(toRemove);
            uut.update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uut.addHole(0, 100);
            uut.addHole(101, 500);
            uut.addHole(602, 200);
            uut.addHole(803, 300);      
            uut.addHole(1104, 600);

            uut.addProcess("P1", 212);
            uut.update();
            MessageBox.Show("sad");
            uut.addProcess("P2", 417);
            uut.update();
            MessageBox.Show("sad");
            uut.addProcess("P3", 112);
            uut.update();
            MessageBox.Show("sad");
            uut.addProcess("P4", 426);
            uut.update();
            MessageBox.Show("sad");

        }
    }
}
