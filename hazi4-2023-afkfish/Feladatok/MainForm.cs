namespace MultiThreadedApp
{
    public partial class MainForm : Form
    {
        private ManualResetEvent mre = new ManualResetEvent(false);
        private ManualResetEvent mreStop = new ManualResetEvent(false);
        private AutoResetEvent are = new AutoResetEvent(false);
        private int start = 0;
        private long steps = 0;
        private object lockObject = new object();
        private bool stopBikes = false;

        public MainForm()
        {
            InitializeComponent();
            // a kezdo pozicio eltarolasa kesobbre
            start = bBike1.Left;
        }

        public void BikeThreadFunction(object param)
        {
            try
            {
                // elmennek a startbol a step1-re
                var bike = (Button)param;
                while (bike.Left < pStep.Left)
                {
                    if (stopBikes)
                    {
                        // ha a stop gombot megnyomtak, akkor a szalat leallitjuk
                        return;
                    }
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
                // megvarjuk amig a step1 gombra nem nyomnak
                //mre.WaitOne();
                waitingMRE(bike);
                // elmennek a step1bol a step2-re
                while (bike.Left < pDepo.Left)
                {
                    if (stopBikes)
                    {
                        return;
                    }
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
                // megvarjuk amig a step2 gombra nem nyomnak
                //are.WaitOne();
                waitingARE(bike);
                // elmennek a step2bol a target-re
                while (bike.Left < pTarget.Left)
                {
                    if (stopBikes)
                    {
                        return;
                    }
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
            }
            catch (ThreadInterruptedException)
            {
                return;
            }
        }

        Random random = new Random();

        public void MoveBike(Button bike)
        {
            if (InvokeRequired)
            {
                Invoke(MoveBike, bike);
            }
            else
            {
                int tmp = random.Next(2, 8);
                IncreasePixels(tmp);
                bike.Left += tmp;
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartBike(bBike1);
            StartBike(bBike2);
            StartBike(bBike3);
        }

        private void StartBike(Button bBike)
        {
            var t = new Thread(BikeThreadFunction)
            {
                IsBackground = true, // Ne blokkolja a szal a processz megszuneset
            };

            bBike.Tag = t;
            t.Start(bBike);
        }

        private void bStep1_Click(object sender, EventArgs e)
        {
            mre.Set();
        }

        private void bStep2_Click(object sender, EventArgs e)
        {
            are.Set();
        }

        void IncreasePixels(long step)
        {
            lock (lockObject)
            {
                steps += step;
            }
        }

        long GetPixels()
        {
            lock (lockObject)
            {
                return steps;
            }
        }

        private void bStepsCount_Click(object sender, EventArgs e)
        {
            bStepsCount.Text = GetPixels().ToString();
        }

        private void bBike1_Click(object sender, EventArgs e)
        {
            // a gombra kattintva a szalat leallitjuk es visszaallitjuk a kezdo poziciojara
            // a manual reset eventet is visszaallitjuk
            Button bike = (Button)sender;
            Thread thread = (Thread)bike.Tag;

            if (thread == null)
                return;

            thread.Interrupt();
            thread.Join();
            mre.Reset();

            bike.Left = start;
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            // a stop gombra kattintva a szalakat leallitjuk
            stopBikes = true;
            mreStop.Set();
        }

        private void waitingMRE(Button bBike)
        {
            // letrehozunk egy szalat addig amig varjuk a step1 gombra valo kattintast
            // es ha kozben megnyomtak a stop gombot, akkor a szalat leallitjuk
            var t = new Thread(mreAreThread)
            {
                IsBackground = true,
            };
            bBike.Tag = t;
            t.Start(bBike);
            mre.WaitOne();
            t.Interrupt();
        }

        private void waitingARE(Button bBike)
        {
            // letrehozunk egy szalat addig amig varjuk a step2 gombra valo kattintast
            // es ha kozben megnyomtak a stop gombot, akkor a szalat leallitjuk
            var t = new Thread(mreAreThread)
            {
                IsBackground = true,
            };
            bBike.Tag = t;
            t.Start(bBike);
            are.WaitOne();
            t.Interrupt();
        }

        private void mreAreThread(Object bBike)
        {
            try
            {
                // ha a stop gombot megnyomtak, akkor a szalat leallitjuk
                mreStop.WaitOne();
                Button bike = (Button)bBike;
                Thread thread = (Thread)bike.Tag;

                if (thread == null)
                    return;

                thread.Interrupt();
                thread.Join();
            }
            catch (ThreadInterruptedException)
            {
                // nem lett megnyomva ezert nem tortenik semmi es visszaterunk
                return;
            }
        }
    }
}