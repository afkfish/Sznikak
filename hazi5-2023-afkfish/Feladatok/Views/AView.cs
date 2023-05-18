using Signals.DocView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signals.Views
{
    public class AView : UserControl, IView
    {
        protected SignalDocument document;
        public int ViewNumber { get; set; }

        public Document GetDocument()
        {
            return document;
        }

        public new void Update()
        {
            if (InvokeRequired)
            {
                Invoke(Invalidate);
            }
        }
    }
}
