using System;
using System.Threading;

namespace ThreadProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfThreads = 64;
            ThreadRun tws = new ThreadRun();
            for (int i = 0; i < numberOfThreads; i++)
                new Thread(new ThreadStart(tws.NewThread)).Start();

        }
    }
}
