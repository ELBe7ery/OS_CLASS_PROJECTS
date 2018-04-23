using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace OS_MEMORY_ASSIGNMENT
{
    enum State
    {
        Hole, Process
    }

    class MemoryLocation
    {
        public State locState;
        public int locSize;
        public int startAddress;
        public string pName;
        public Color locationColor;
        public MemoryLocation nextLocation;

        public MemoryLocation(int strtAdrs, int locsize, string name, Color loClr, State theState)
        {
            startAddress = strtAdrs;
            locSize = locsize;
            pName = name;
            locState = theState;
            locationColor = loClr;
            nextLocation = null;
        }

    }

    class MemoryContainer
    {
        //------Friend Class-----

        Func<MemoryLocation, MemoryLocation, bool> srt, visualSrt;  //Either sorts by address, or sorts by size
        ZedGraphControl zg1;
        MemoryLocation head, visualHead;
        Color[] RandomColors;
        RichTextBox simLog;
        ListBox taskManger;
        int lastKnownAddress;
        int totalAvailableSize;   //Will be changed only when AddProcess(), RemoveProcess(), AddHole()
        int colorIndex;
        int otherProcessesSize,dummySize;
        bool dummyBool, dummyBool1, compaction;

        public MemoryContainer(Func<MemoryLocation, MemoryLocation, bool> doSort, Func<MemoryLocation, MemoryLocation, bool> vslSort, ZedGraphControl zedObj, RichTextBox logText,ListBox tskMgr, bool compct=false)
        {
            srt = doSort;
            visualSrt = vslSort;
            zg1 = zedObj;
            simLog = logText;
            taskManger = tskMgr;
            head = null;
            //visualHead = null;
            //lastKnownAddress = 0;
            RandomColors = new Color[] {Color.YellowGreen,Color.IndianRed,Color.DarkMagenta,Color.Goldenrod
                                        ,Color.Lavender,Color.Coral,Color.Firebrick,Color.LavenderBlush
                                        ,Color.YellowGreen,Color.PeachPuff,Color.DarkViolet};
            colorIndex = 0;
            compaction = compct;
            otherProcessesSize = 0;
            dummySize = 0;
            //dummyBool = true;
            //dummyBool1 = true;
        }

        public void addHole(int holeStartAddr, int holeSize,bool doCheck=true)
        {
            if (holeSize == 0)
                return; 
            
            totalAvailableSize += holeSize;
            MemoryLocation p = new MemoryLocation(holeStartAddr, holeSize, "Hole",Color.Black,State.Hole);
            p.nextLocation = null;
            if (doCheck && expandSomeHole(holeStartAddr, holeSize))
                return;
            if (doCheck)
                log("Adding hole of size: " + holeSize + " at " + holeStartAddr);
            else
                log("Lowering the size of this hole to start at: " + holeStartAddr + " With a new size = " + holeSize);
            if (head == null)
            {
                head = p;
                return;
            }
            MemoryLocation ptr = head;
            if (srt(ptr, p) == false)
            {
                p.nextLocation = head;
                head = p;
                return;
            }
            while (ptr.nextLocation != null)
            {
                if (srt(ptr.nextLocation, p) == false)
                {
                    p.nextLocation = ptr.nextLocation;
                    ptr.nextLocation = p;
                    return;
                }
                ptr = ptr.nextLocation;
            }
            ptr.nextLocation = p;

        }

        private bool expandSomeHole(int holeStartAddr, int holeSize)
        {
            bool ret = false;
            int mergeEndAddr =-1, mergeUpAddr = -1;
            MemoryLocation ptr = head;
            MemoryLocation upLoc = head;
            while(ptr!=null)
            {
                if (ptr.startAddress + ptr.locSize == holeStartAddr && ptr.locState == State.Hole)
                {
                    ptr.locSize += holeSize;
                    log("Expanding Hole at: " + ptr.startAddress+" With a new size = "+ptr.locSize);
                    mergeEndAddr = ptr.startAddress + ptr.locSize;
                    upLoc = ptr;
                    ret = true;
                    ptr = head;
                    break;
                }

                else if(ptr.startAddress== holeStartAddr+holeSize && ptr.locState == State.Hole)
                {
                    log("Expanding Hole that was at: " + ptr.startAddress+" To start at: "+holeStartAddr + " And its size will be increased by: "+ holeSize);
                    ptr.startAddress = holeStartAddr;
                    ptr.locSize += holeSize;

                    mergeUpAddr = ptr.startAddress;
                    upLoc = ptr;
                    ret = true;
                    ptr = head;
                    break;
                }
                ptr = ptr.nextLocation;
            }
            while(ret && ptr.nextLocation!=null)
            {
               if (ptr.nextLocation.startAddress == mergeEndAddr && ptr.nextLocation.locState == State.Hole)
                {
                    upLoc.locSize += ptr.nextLocation.locSize;
                    log("Expanding Hole at: " + upLoc.startAddress + " With a new size = " + upLoc.locSize);
                    ptr.nextLocation = ptr.nextLocation.nextLocation;
                    break;
                }
               else if(ptr.nextLocation.startAddress+ptr.nextLocation.locSize== mergeUpAddr && ptr.nextLocation.locState == State.Hole)
                {
                    log("Expanding Hole that was at: " + ptr.nextLocation.startAddress + " To start at: " + mergeUpAddr + " And its size will be increased by: " + ptr.nextLocation.locSize);
                    upLoc.startAddress = ptr.nextLocation.startAddress;
                    upLoc.locSize += ptr.nextLocation.locSize;
                    ptr.nextLocation = ptr.nextLocation.nextLocation;
                    break; 
                }
               ptr = ptr.nextLocation;
            }
            return ret;
        }

        public void addProcess(string pName, int pSize,bool justAdded=false)
        {
            MemoryLocation ptr = head;
            while (ptr != null)
            {
                //Keep looping till the proper hole is spoted !
                //For first fit => sort by smaller addr
                //For best fit => sort by smaller hole size
                //For worst fit => sort by bigger hole size
                if (ptr.locSize >= pSize && ptr.locState == State.Hole)
                {
                    ptr.locState = State.Process;
                    ptr.pName = pName;
                    ptr.locationColor = RandomColors[colorIndex];
                    colorIndex = (colorIndex + 1) % 10;
                    int theLeftHoleSize = ptr.locSize - pSize;
                    log(pName + " Is added to the hole of size: " + ptr.locSize +" Which starts at: "+ptr.startAddress+ " And left a space = "+theLeftHoleSize);
                    totalAvailableSize -= ptr.locSize;
                    ptr.locSize = pSize;                    
                    taskManger.Items.Add(pName + " : " + pSize.ToString());
                    addHole(ptr.startAddress + pSize, theLeftHoleSize,false);
                    //MessageBox.Show(totalAvailableSize.ToString());
                    return;
                }
                ptr = ptr.nextLocation;
            }
            if(pSize<=totalAvailableSize)
            {
                if (compaction & !justAdded)
                {
                    log("Running the memory compaction algorithm to fit the new process in");
                    compactionAlgorithm();
                    addProcess(pName, pSize, !justAdded);
                }
                else
                    log("Fragmentation Error\nTotal Available Size is :" + totalAvailableSize + " But due to Fragmentation you cant insert process \"" + pName + "\" in the memory. You might want to use the compaction algorithm to fit this process in!");
            }
            else
                log("Ops, looks like no enough holes to insert process \"" + pName + "\" in the memory. Please add more holes!");
        }

        public void compactionAlgorithm()
        {
            MemoryLocation ptr = head;
            int pStartAdrr = 0;
            //Shift Processes down
            while (ptr!=null)
            {
                if(ptr.locState==State.Process)
                {
                    ptr.startAddress = pStartAdrr;
                    //Process.CopyToStartAddress(int startAddress);
                    pStartAdrr += ptr.locSize;
                }
                ptr = ptr.nextLocation;
            }
            ptr = head;
            //Get the first hole
            while(ptr!=null)
            {
                if (ptr.locState == State.Hole)
                {                   
                    ptr.startAddress = pStartAdrr;
                    ptr.locSize = totalAvailableSize;
                    ptr = ptr.nextLocation;
                    break;
                }
                ptr = ptr.nextLocation;
            }
            //Set all the other holes size to zero
            while (ptr!=null)
            {
                if (ptr.locState == State.Hole)
                    ptr.locSize = 0;
                ptr = ptr.nextLocation;
            }
            ptr = head;
            if (ptr.locSize == 0)
                ptr = ptr.nextLocation;
            while(ptr.nextLocation!=null)
            {
                //Skip zero holes, garbage collector b2a
                if (ptr.nextLocation.locSize == 0)
                {
                    ptr.nextLocation = ptr.nextLocation.nextLocation;
                    continue;
                }
                if (ptr.nextLocation == null)
                    break;
                else
                    ptr = ptr.nextLocation;
            }
        }

        public void removeProcess(string pName)
        {
            MemoryLocation ptr = head;
            int sizeToCreate, addrToCreate = 0;
            while (ptr.nextLocation!=null)
            {
                if(ptr.nextLocation.pName==pName)
                {
                    log("Found process \"" + pName + "\" and de-allocating its space");
                    sizeToCreate = ptr.nextLocation.locSize;
                    addrToCreate = ptr.nextLocation.startAddress;
                    ptr.nextLocation = ptr.nextLocation.nextLocation;
                    addHole(addrToCreate, sizeToCreate);
                    break;
                }
                ptr = ptr.nextLocation;
            }
        }

        public void update()
        {
            MemoryLocation ptr = head;
            visualHead = null;
            dummyBool = true;
            dummyBool1 = true;
            lastKnownAddress = 0;

            zg1.GraphPane.CurveList.Clear();
            while (ptr != null)
            {
                addVisual(ptr);
                ptr = ptr.nextLocation;
            }
            ptr = visualHead;
            while (ptr!=null)
            {
                stackLocation(ptr);
                ptr = ptr.nextLocation;
            }
        }

        private void stackLocation(MemoryLocation memLoc)
        {
            string barName = "";
            //if (memLoc.locSize == 0) return;
            if (memLoc.locState==State.Hole)
            {
                if (dummyBool1) barName = "Hole";
                dummyBool1 = false;
            }
            else
                barName = memLoc.pName;

            //barName = memLoc.pName;
            ZedGraph.PointPairList pointAdded = new ZedGraph.PointPairList();   //A member inside my class, you might want to pass it as an arg 
            if (memLoc.startAddress != lastKnownAddress)
            {
                var dede = memLoc.startAddress - lastKnownAddress;
                stackUnknwn(memLoc.startAddress - lastKnownAddress);
            }
            lastKnownAddress = memLoc.startAddress + memLoc.locSize;
            pointAdded.Add(0,memLoc.locSize);
            BarItem barC = zg1.GraphPane.AddBar(barName, pointAdded, memLoc.locationColor);
            barC.Bar.Fill = new Fill(memLoc.locationColor);

            zg1.AxisChange();
            zg1.Refresh();
        }

        private void stackUnknwn(int unKnwnSpace)
        {
            string barName = "";
            if(dummyBool)
            {
                barName = " ";
                dummyBool = false;
            }
            ZedGraph.PointPairList pointAdded = new ZedGraph.PointPairList();   //A member inside my class, you might want to pass it as an arg 
            pointAdded.Add(0, unKnwnSpace);
            BarItem barC = zg1.GraphPane.AddBar(barName, pointAdded, Color.SkyBlue);
            barC.Bar.Fill = new Fill(Color.SkyBlue);
            zg1.AxisChange();
            zg1.Refresh();
        }

        private void addVisual(MemoryLocation pp)
        {
            MemoryLocation p = new MemoryLocation(pp.startAddress, pp.locSize, pp.pName, pp.locationColor, pp.locState);
            p.nextLocation = null;
            if (visualHead == null)
            {
                visualHead = p;
                return;
            }
            MemoryLocation ptr = visualHead;
            if (visualSrt(ptr, p) == false)
            {
                p.nextLocation = visualHead;
                visualHead = p;
                return;
            }
            while (ptr.nextLocation != null)
            {
                if (visualSrt(ptr.nextLocation, p) == false)
                {
                    p.nextLocation = ptr.nextLocation;
                    ptr.nextLocation = p;
                    return;
                }
                ptr = ptr.nextLocation;
            }
            ptr.nextLocation = p;

        }

        private void log(string msg)
        {
            simLog.Text += "\n" + msg + "\n";
            simLog.SelectionStart = simLog.Text.Length;
            simLog.ScrollToCaret();
        }
    }
}
