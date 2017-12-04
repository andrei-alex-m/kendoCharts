using System;
using System.Collections.Generic;
using System.Text;

namespace coreCharts
{
    public class Title
    {
        public string Background { get; set; }
        //from GaugeDescriptor
        public object Border { get; set; }
        public string  Color { get; set; }
        public string  Font { get; set; }
        public int Margin { get; set; }
        //left, right, center, turn to enum
        public string Position { get; set; }
        public string Text { get; set; }
        //enum converter
        public bool Visible { get; set; }
        //function
        public string Visual { get; set; }


    }
}
