using System;
using System.Collections.Generic;
using System.Text;

namespace coreCharts
{
    public class Legend
    {
        public string Align { get; set; }
        public string Background { get; set; }
        //from GaugeDescriptor
        public object Border { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        // check if necessary
        public object InactiveItems { get; set; }
        public LegendItem Item { get; set; }
        public LegendLabels Labels { get; set; }
        public int Margin { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public string Orientation { get; set; }
        public int Padding { get; set; }
        //enum to string
        public bool Reverse { get; set; }
        public bool Visible { get; set; }

    }
}
