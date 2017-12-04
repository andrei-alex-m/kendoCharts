using System;
using System.Collections.Generic;
using System.Text;

namespace coreCharts
{
    public class PlotArea
    {
        public string Background { get; set; }
        //Border from GaugeDescriptor
        public object Border { get; set; }
        public int Margin { get; set; }
        public double Opacity{ get; set; }
        public int Padding { get; set; }
    }
}
