using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logging.Components
{
    using System.Linq;
    using System.Collections.Generic;
    using FMS.UI.Infrastructure;

    public class IsoStoreService : IIsoStoreService
    {
        public IsoStoreFront FetchStoreFront()
        {
            return this.IsoStoreFront;
        }

        private IsoStoreFront isoStoreFront;
        public IsoStoreFront IsoStoreFront
        {
            get
            {
                if (this.isoStoreFront == null)
                {
                    this.isoStoreFront = new IsoStoreFront();
                }
                return this.isoStoreFront;
            }
        }

        public void WriteToStore(IList<TraceEntry> traceEntries)
        {
            traceEntries.ToList().ForEach(te => this.IsoStoreFront.Add(te.ScreenKeyType, te));
        }

        public void WriteToStore(IList<LogEntry> logEntries)
        {
            logEntries.ToList().ForEach(le => this.IsoStoreFront.Add(le.ScreenKeyType, le));
        }
    }

}
