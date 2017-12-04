using System;
using Newtonsoft.Json;
namespace coreCharts
{
    public class ChartArea
    {
        public string Background { get; set; }
        //merge with Border from GaugeDescriptop
        public object Border { get; set; }
        public int Height { get; set; }
        public int Margin { get; set; }
        public double Opacity { get; set; }
        public double Width { get; set; }
        public object DataSource { get; set; }
        public Legend Legend { get; set; }
        //enum converter
        public bool Pannable { get; set; }
        [JsonProperty("pannable.key")]
        public string  PannableKey { get; set; }
        [JsonProperty("pannable.lock")]
        public string PannableLock { get; set; }
        public PlotArea PlotArea { get; set; }
        public object MyProperty
        {
            get;
            set;
        }
    }

}
