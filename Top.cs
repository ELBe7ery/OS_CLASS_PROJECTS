using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace OS_SCHEDULER
{
    class Top
    {
        public int quanta;
        public Q timeArrivalFIFO;
        public Q pq;
        public bool busy;
        public bool abort;
        public bool pre;
        public Process p2exe, p2Add;
        public Func<Process, Process, bool> srt;
        ZedGraphControl zg1;
        double avgWait;
        int numProcesses;
        public Top(ZedGraphControl z ,Q timeFIFO, Func<Process, Process, bool>  sortFunc, bool preEmptive= false, int q= -1)
        {
            zg1 = z;
            timeArrivalFIFO = timeFIFO;
            pq = new Q(sortFunc);
            busy = false;
            srt = sortFunc;
            abort = false;
            pre = preEmptive;
            p2exe = null;
            p2Add = null;
            quanta = q;
        }
        bool dummyFlag = false;
        public void sim(MaterialFlatButton avgTimeButton)
        {
            int t = -1;
            numProcesses = 0;
            avgWait = 0;
            while (timeArrivalFIFO.head != null || pq.head!= null)
            {
                t += 1;
                if(p2exe!=null && (t - p2exe.lastStart == quanta))
                    abort = true;
                while (timeArrivalFIFO.head != null && timeArrivalFIFO.head.arrivalTime <= t)
                {
                    p2Add = timeArrivalFIFO.pop();
                    numProcesses += 1;
                    p2Add.enter(t);
                    pq.addProcess(p2Add);
                    if (pre == true && p2exe != null && srt(p2Add, p2exe))
                        abort = true;
                }
                if (pq.head != null && busy == false)
                    {
                        p2exe = pq.pop();
                        p2exe.execute(t);
                        busy = true;
                        abort = false;
                        //Print, or add to the graph here
                        //l.Items.Add(p2exe.name + " At: " + p2exe.lastStart.ToString() + " Burst "+p2exe.burst);
                    }

                if (p2exe == null)
                    stackBarEmpty(t);
                else if ((t - p2exe.lastStart == p2exe.burst) || abort)
                {
                    busy = false;
                    p2exe.yld(t);
                    stackBar(p2exe, t);
                    t -= 1;
                    avgWait += p2exe.wait;
                    if(!p2exe.done)
                    {
                        pq.addProcess(p2exe);
                        p2exe.enter(t + 1);
                    }
                    if(timeArrivalFIFO.head!=null)
                        p2exe = null;
                }
            }


            while (t - p2exe.lastStart != p2exe.burst) t++;
            p2exe.yld(t);
            stackBar(p2exe, t);
            avgWait += p2exe.wait;
            //Print last thing, average time;
            //l.Items.Add(avgWait / numProcesses);
            stackBarAvgTime();
            avgTimeButton.Text = "Average Time: " + (avgWait / numProcesses).ToString();
        }

        private void stackBar(Process p,int t)
        {
            string barName= "";
            
            if (p.executionTimes==1)
                barName = p.name;
            ZedGraph.PointPairList pointAdded = new ZedGraph.PointPairList();   //A member inside my class, you might want to pass it as an arg
            pointAdded.Add(t-p.lastStart, 0);
            pointAdded.Add(0, 1);

            //pointAdded.Add(avgWait / numProcesses, 0);
            BarItem barC = zg1.GraphPane.AddBar(barName, pointAdded, p.clr);
            barC.Bar.Fill = new Fill(p.clr);

            zg1.AxisChange();
            zg1.Refresh();
        }
        private void stackBarAvgTime()
        {
            ZedGraph.PointPairList pointAdded = new ZedGraph.PointPairList();   //A member inside my class, you might want to pass it as an arg
            pointAdded.Add(0, 1);
            pointAdded.Add(avgWait / numProcesses, 1);
            //pointAdded.Add(avgWait / numProcesses, 0);
            BarItem barC = zg1.GraphPane.AddBar("Average Time", pointAdded, Color.GreenYellow);
            barC.Bar.Fill = new Fill(Color.GreenYellow);

            zg1.AxisChange();
            zg1.Refresh();
        }
        private void stackBarEmpty(int t)
        {
            string label = "";
            if (!dummyFlag)
            {
                label = "Empty";
                dummyFlag = true;
            }
            ZedGraph.PointPairList pointAdded = new ZedGraph.PointPairList();   //A member inside my class, you might want to pass it as an arg
            pointAdded.Add(1, 1);
            pointAdded.Add(0, 1);
            //pointAdded.Add(avgWait / numProcesses, 0);
            BarItem barC = zg1.GraphPane.AddBar(label, pointAdded, Color.Black);
            barC.Bar.Fill = new Fill(Color.Black);

            zg1.AxisChange();
            zg1.Refresh();
        }
    }
}
