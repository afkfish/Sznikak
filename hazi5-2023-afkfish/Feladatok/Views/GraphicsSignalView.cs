using Signals.Views;
using System.Drawing.Drawing2D;

namespace Signals
{
    public partial class GraphicsSignalView : AView
    {

        private static double pixelsPerSecond;
        private static int pixelsPerValue;
        private double scale = 1;
        private Size initial;
        private int scrollX = 0;
        private int scrollY = 0;

        public GraphicsSignalView()
        {
            InitializeComponent();
        }

        public GraphicsSignalView(SignalDocument document)
            : this()
        {
            this.document = document;
            AutoScrollMinSize = ClientSize;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            lock(document.syncObj)
            {
                if (initial.Width == 0)
                {
                    initial = Size;
                }
                scrollX = AutoScrollPosition.X;
                scrollY = AutoScrollPosition.Y;

                e.Graphics.Transform = new Matrix(1, 0, 0, 1, scrollX, scrollY);

                // uj ceruza a piontokhoz
                var pen = new Pen(Color.Blue, 2)
                {
                    DashStyle = DashStyle.Dot,
                    EndCap = LineCap.ArrowAnchor,
                };
                // uj ceruza a vonalakhoz
                var pen2 = new Pen(Color.Blue, 1);
                // tengelyek kirajzolasa
                e.Graphics.DrawLine(pen, new Point(2, (int)(ClientSize.Height * scale)), new Point(2, 0));
                e.Graphics.DrawLine(pen, new Point(0, (int)(ClientSize.Height * scale / 2)), new Point((int)(ClientSize.Width * scale), (int)(ClientSize.Height * scale / 2)));

                // a maximum ido kulonbseg kiszamitasa ahoz hogy a leheto legtobb
                // helyet tudja mejd elfoglalni szelessegben a grafikon
                var timeDelta = document.Signals.Last().TimeStamp - document.Signals.First().TimeStamp;
                // masodpercenkenti pixel arany
                pixelsPerSecond = ClientSize.Width * scale / (timeDelta.Ticks / 1000000);
                // ertekek szerinti pixel arany
                pixelsPerValue = (int)((ClientSize.Height * scale / 2) / document.Signals.Max(x => Math.Abs(x.Value)));

                var x = 0.0;
                var lastTime = document.Signals.First().TimeStamp;
                var points = new List<Point>();
                foreach (var signal in document.Signals)
                {
                    // a pont y koordinata szamitasa
                    var y = signal.Value * pixelsPerValue;
                    // az elozo pont ota masodperces delta szamitasa
                    var d = (signal.TimeStamp - lastTime).Ticks / 1000000;
                    // z koordinata szamitasa
                    x += (int)(pixelsPerSecond * d);
                    // skalazas
                    var xT = x;
                    var yT = ClientSize.Height * scale / 2 - y;
                    points.Add(new Point((int)xT, (int)yT));
                    // kirajzolas
                    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle((int)xT, (int)yT, 3, 3));
                    lastTime = signal.TimeStamp;
                }
                var lastPoint = points.First();
                // vonalak kirajzolasa
                foreach (var point in points)
                {
                    if (point != lastPoint)
                    {
                        e.Graphics.DrawLine(pen2, lastPoint, point);
                        lastPoint = point;
                    }
                }
            }
        }

        private void bZoomIn_Click(object sender, EventArgs e)
        {
            scale *= 1.2;
            AutoScrollMinSize = new Size((int)(initial.Width * scale), (int)(initial.Height * scale));
            Invalidate();
        }

        private void bZoomOut_Click(object sender, EventArgs e)
        {
            scale /= 1.2;
            AutoScrollMinSize = new Size((int)(initial.Width * scale), (int)(initial.Height * scale));
            Invalidate();
        }
    }
}
