
using System.Drawing;

namespace OS_SCHEDULER
{
    class Process
    {
        public string name;
        public int burst;
        public int lastStart;
        public int wait;
        public int arrivalTime;
        public Process nextProcess;
        public int lastEnter;
        public int quanta;
        public bool done;
        public int priority;
        public Color clr;
        public int executionTimes;
        public Process(int burstArg,string nameArg,int arrTimeArg,int priorityArg,Color c)
        {
            name = nameArg;
            burst = burstArg;
            quanta = burstArg;
            lastStart = 0;
            lastEnter = 0;
            done = false;
            wait = 0;
            arrivalTime = arrTimeArg;
            nextProcess = null;
            priority = priorityArg;
            clr = c;
            executionTimes = 0;
        }

        public void execute(int t)
        {
            wait = t - lastEnter;
            lastStart = t;
            executionTimes ++;
        }

        public void yld(int t)
        {
            burst -= t - lastStart;
            if(burst==0)
                done = true;
            arrivalTime = t;
        }
        public void enter(int t)
        {
            lastEnter = t;
        }
    }
}
