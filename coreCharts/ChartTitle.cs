using System;
using System.Collections.Generic;
using System.Text;

namespace coreCharts
{
    public class ChartTitle:Title
    {
        //center, left, right
        public string Align { get; set; }
        public int Padding { get; set; }
        //top, bottom
        public string Position { get; set; }

    }
}
