using Signals.DocView;
using System.Diagnostics;

namespace Signals
{
    public class SignalDocument : Document
    {
        private List<SignalValue> signals = new List<SignalValue>();
        public IReadOnlyList<SignalValue> Signals
        {
            get { return signals; }
        }

        private SignalValue[] testValues = new SignalValue[]
        {
            new SignalValue(10, new DateTime(2023, 4, 1, 0, 0, 0, 111)),
            new SignalValue(20, new DateTime(2023, 4, 1, 0, 0, 1, 876)),
            new SignalValue(30, new DateTime(2023, 4, 1, 0, 0, 2, 300)),
            new SignalValue(10, new DateTime(2023, 4, 1, 0, 0, 3, 232)),
            new SignalValue(-10, new DateTime(2023, 4, 1, 0, 0, 5, 885)),
            new SignalValue(-19, new DateTime(2023, 4, 1, 0, 0, 6, 125)),
        };
        public SignalDocument(string name) : base(name)
        {
            signals.AddRange(testValues);
        }

        public override void SaveDocument(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (SignalValue signalValue in signals)
                {
                    var utcTime = signalValue.TimeStamp.ToUniversalTime().ToString("O");
                    sw.WriteLine($"{signalValue.Value}\t{utcTime}");
                }
            }
        }

        public override void LoadDocument(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                signals.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var col = line.Split('\t');
                    var value = double.Parse(col[0]);
                    DateTime dt = DateTime.Parse(col[1]);
                    var localDt = dt.ToLocalTime();

                    signals.Add(new SignalValue(value, localDt));
                }
                UpdateAllViews();
            }
            TraceValues();
        }

        private void TraceValues()
        {
            foreach (var signal in signals)
                Trace.WriteLine(signal.ToString());
        }

        protected override void genDataThread()
        {
            try
            {
                Random rnd = new Random();
                while (liveData)
                {
                    lock (syncObj)
                    {
                        signals.Add(new SignalValue(rnd.NextDouble() * 40 - 20, DateTime.Now));
                        Trace.WriteLine(DateTime.Now);
                    }
                    Thread.Sleep((int)rnd.NextInt64(100, 500));
                }
            } catch (ThreadInterruptedException)
            {
            }
        }

        protected override void updateLiveDataThread()
        {
            try
            {
                while (true)
                {
                    UpdateAllViews();
                    Thread.Sleep(200);
                }
            } catch (ThreadInterruptedException)
            {
            }
        }
    }
}
