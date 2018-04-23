using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_SCHEDULER
{
    class Q
    {
        public Func<Process, Process,bool> srt;
        public Process head;
        public Q(Func<Process, Process, bool> sortFunct)
        {
            srt = sortFunct;
            head = null;
        }
        public void addProcess(Process p)
        {
            p.nextProcess = null;
            if(head==null)
            {
                head = p;
                return;
            }
            Process ptr = head;
            if(srt(ptr,p)==false)
            {
                p.nextProcess = head;
                head = p;
                return;
            }
            while (ptr.nextProcess!=null)
            {
                if (srt(ptr.nextProcess, p) == false)
                {
                    p.nextProcess = ptr.nextProcess;
                    ptr.nextProcess = p;
                    return;
                }
                ptr = ptr.nextProcess;
            }
            ptr.nextProcess = p;

        }

        public Process pop()
        {
            Process ret = head;
            head = head.nextProcess;
            return ret;
        }

    }
}
