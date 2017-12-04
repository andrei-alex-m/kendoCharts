using System;
using System.Collections.Generic;
using System.Text;

namespace coreCharts
{
    public class Series
    {
        // avg, count, max, min, sum, sumOrNull, first
        // can be custom function
        public string Aggregate { get; set; }
        public string Axis { get; set; }
        //from GuageDescriptor
        public object Border { get; set; }
        //when inline data
        public string CategoryAxis { get; set; }
        //whn DataSource
        public string CategoryField { get; set; }
        //only for candlestick or olhc
        public string CloseField { get; set; }
        public string Color { get; set; }
        public string ColorField { get; set; }
        //donut & pie 
        public object Connectors { get; set; }
        public string CurrentField { get; set; }
        //must have been defined as enum alreadee
        public string DashType { get; set; }
        //only for inline data
        public object[] Data { get; set; }
        //only for candlestick
        public string DownColor { get; set; }
        //only for candlestick
        public string DownColorField { get; set; }
        //only for funnel
        public int SegmentSpacing { get; set; }
        //for waterfal series summary columns
        //runningTotal, total
        public string SummaryField { get; set; }
        //funnel chart; topwidth/bottom width
        public double NeckRatio { get; set; }
        //funnel
        public bool DynamicSlope { get; set; }
        //funnel
        public bool DynamicHeight { get; set; }
        //study
        public object ErrorBars { get; set; }

        ///multiple error related fields here

        //donut, pie
        public string ExplodeField { get; set; }


    }
}
