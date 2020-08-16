using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ThreadProgram
{
    public class ThreadRun
    {
        private int place;

        public void NewThread()
        {
            var sW = new Stopwatch();
            sW.Start();
            Hanoi();
            sW.Stop();
            place++;
            Console.WriteLine($"time: {sW.Elapsed} thread: {place}");
        }

        private static void Hanoi()
        {
            char startPeg = 'A'; // start tower in output
            char endPeg = 'C'; // end tower in output
            char tempPeg = 'B'; // temporary tower in output
            int totalDisks = 30; // number of disks

            SolveTowers(totalDisks, startPeg, endPeg, tempPeg);
        }

        private static void SolveTowers(int n, char startPeg, char endPeg, char tempPeg)
        {
            if (n > 0)
            {
                SolveTowers(n - 1, startPeg, tempPeg, endPeg);
                //Console.WriteLine("Move disk from " + startPeg + ' ' + endPeg);
                SolveTowers(n - 1, tempPeg, endPeg, startPeg);
            }
        }


    }
}
