using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormDemo
{
    public class CompDetail
    {
        public string w { get; set; }
        public string h { get; set; }
    }

    public class Example
    {
        public string w { get; set; }
        public string p { get; set; }
        public string m { get; set; }
        public string h { get; set; }
    }

    public class Result
    {
        public string kanji { get; set; }
        public string comp { get; set; }
        public string detail { get; set; }
        public string level { get; set; }
        public string _id { get; set; }
        public string stroke_count { get; set; }
        public string freq { get; set; }
        public string on { get; set; }
        public string mean { get; set; }
        public List<CompDetail> compDetail { get; set; }
        public string kun { get; set; }
        public List<Example> examples { get; set; }
    }

    public class RootObject
    {
        public int status { get; set; }
        public List<Result> results { get; set; }
    }
}
