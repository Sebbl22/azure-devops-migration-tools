using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Microsoft.ApplicationInsights.DataContracts;
using Serilog;

namespace MigrationTools.Host.Services
{
    public class DetectOnlineService : IDetectOnlineService
    {
        private readonly ITelemetryLogger _Telemetry;

        public DetectOnlineService(ITelemetryLogger telemetry)
        {
            _Telemetry = telemetry;
        }

        public bool IsOnline()
        {
            DateTime startTime = DateTime.Now;
            Stopwatch mainTimer = Stopwatch.StartNew();
            //////////////////////////////////
            bool isOnline = false;
            string response = "none";
            try
            {
                Ping myPing = new Ping();
                String host = "8.8.4.4";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                response = reply.Status.ToString();
                if (reply.Status == IPStatus.Success)
                {
                    isOnline = true;
                }
                mainTimer.Stop();
                _Telemetry.TrackDependency(new DependencyTelemetry("Ping", "GoogleDNS", "IsOnline", null, startTime, mainTimer.Elapsed, response, true));
            }
            catch (Exception ex)
            {
                mainTimer.Stop();
                // Likely no network is even available
                Log.Error(ex, "Error checking if we are online.");
                response = "error";
                isOnline = false;
                _Telemetry.TrackDependency(new DependencyTelemetry("Ping", "GoogleDNS", "IsOnline", null, startTime, mainTimer.Elapsed, response, false));
            }
            /////////////////
            mainTimer.Stop();
            return isOnline;
        }
    }
}