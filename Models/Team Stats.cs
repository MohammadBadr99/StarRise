using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Ranking_Reporter.Models
{
    internal class Team_Stats
    {
        //float avgCRU, avgOnsite, avg30DRRR, avg7DRRR, avgPPSNR, avgOSATScore, avgProd, totalCru = 0, totalOnsite = 0, totalOSATNo = 0;
        public float avgCru { get; set; }
        public float avgOnsite { get; set; }
        public float avgProd { get; set; }
        public float avg30DRRR { get; set; }
        public float avg7DRRR { get; set; }
        public float avgPPSNR { get; set; }
        public float avgOSATNo { get; set; }
        public float avgOSATScore { get; set; }
        public int totalCru { get; set; }
        public int totalOnSite {  get; set; }
        public int totalOSATNo { get; set; }
    }
}
