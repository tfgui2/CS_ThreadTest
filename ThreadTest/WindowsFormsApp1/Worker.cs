using System;
using System.Threading;

namespace WindowsFormsApp1
{
    class Worker
    {
        private volatile bool _shouldStop = false;

        public void DoWork()
        {
            while (!_shouldStop)
            {
                Console.WriteLine("worker: working..");
                Thread.Sleep(1);
            }

            Console.WriteLine("worer: stop");
        }
        Thread workerThread;

        public void Start()
        {
            _shouldStop = false;
            workerThread = new Thread(DoWork);
            workerThread.Start();
        }

        public void RequestStop()
        {
            _shouldStop = true;
            if (workerThread != null)
            {
                workerThread.Join();
            }
        }

       
    }
}
