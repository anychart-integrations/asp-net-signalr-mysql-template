using System;
using Microsoft.AspNet.SignalR;
using System.Threading;

namespace AspNetSignalRMysqlTemplate.Hubs
{

    public class Broadcaster
    {
        private FruitDBContext db = new FruitDBContext();
        private readonly static Lazy<Broadcaster> _instance = new Lazy<Broadcaster>(() => new Broadcaster());
        // update every 3 seconds
        private readonly TimeSpan BroadcastInterval = TimeSpan.FromMilliseconds(3000);
        private readonly IHubContext _hubContext;
        private Timer _broadcastLoop;

        public Broadcaster()
        {
            // Save our hub context so we can easily use it 
            // to send to its connected clients
            _hubContext = GlobalHost.ConnectionManager.GetHubContext<ChartHub>();
            // Start the broadcast loop
            _broadcastLoop = new Timer(BroadcastSend, null, BroadcastInterval, BroadcastInterval);
        }
        public void BroadcastSend(object state)
        {
            System.Diagnostics.Debug.WriteLine("Update chart");
            var fruits = db.topFruits();
            _hubContext.Clients.All.updateChart(fruits);
        }
        public static Broadcaster Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }

    public class ChartHub : Hub
    {
        private Broadcaster _broadcaster;
        public ChartHub() : this(Broadcaster.Instance)
	    {
        }
        public ChartHub(Broadcaster broadcaster)
        {
            _broadcaster = broadcaster;
        }
    }
}