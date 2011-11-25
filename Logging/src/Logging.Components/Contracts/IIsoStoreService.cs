namespace Logging.Components
{
    using System.Collections.Generic;

    public interface IIsoStoreService
    {
        IsoStoreFront FetchStoreFront();
        IsoStoreFront IsoStoreFront { get; }
        void WriteToStore(IList<TraceEntry> traceEntries);
    }
}
