using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking_Reporter.Models
{
    internal class Agents_Results
    {
        string AgentName;
        float Agent_CRU_Results;
        float Agent_OnSite_Results;
        float Agent_7DRRR_Results;
        float Agent_30DRRR_Results;
        float Agent_PPSNR;
        float Agent_OSAT_No_Results;
        float Agent_OSAT_Score;
        float Agent_Productivity;
        float Agent_Total_Performance;
        int Agent_Rank;

        public void set_Agent_Name(string AgentName)
        {
            this.AgentName = AgentName;
        }
        public void set_Agent_CRU_Results(float res)
        {
            this.Agent_CRU_Results = res;
        }
        public void set_Agent_OnSite_Results(float res)
        {
            this.Agent_OnSite_Results = res;
        }
        public void set_Agent_7DRRR_Results(float res)
        {
            this.Agent_7DRRR_Results = res;
        }
        public void set_Agent_30DRRR_Results(float res)
        {
            this.Agent_30DRRR_Results = res;
        }
        public void set_Agent_PPSNR(float res)
        {
            this.Agent_PPSNR = res;
        }
        public void set_Agent_OSAT_No_Results(float res)
        {
            this.Agent_OSAT_No_Results = res;
        }
        public void set_Agent_OSAT_Score(float res)
        {
            this.Agent_OSAT_Score = res;
        }
        public void set_Agent_Productivity(float res)
        {
            this.Agent_Productivity = res;
        }
        public void set_Agent_Total_Performance(float res)
        {
            this.Agent_Total_Performance = res;
        }
        public void set_Agent_Rank(int res)
        {
            this.Agent_Rank = res;
        }


        //GETS//
        public float get_Agent_CRU_Results()
        {
            return this.Agent_CRU_Results;
        }
        public float get_Agent_OnSite_Results()
        {
            return this.Agent_OnSite_Results;
        }
        public string get_Agent_Name()
        {
            return this.AgentName;
        }
        public float get_Agent_7DRRR_Results()
        {
            return this.Agent_7DRRR_Results;
        }
        public float get_Agent_30DRRR_Results()
        {
            return this.Agent_30DRRR_Results;
        }
        public float get_Agent_PPSNR()
        {
            return this.Agent_PPSNR;
        }
        public float get_Agent_OSAT_No_Results()
        {
            return this.Agent_OSAT_No_Results;
        }
        public float get_Agent_OSAT_Score()
        {
            return this.Agent_OSAT_Score;
        }
        public float get_Agent_Productivity()
        {
            return this.Agent_Productivity;
        }
        public float get_Agent_Total_Performance()
        {
            return this.Agent_Total_Performance;
        }
        public int get_Agent_Rank()
        {
            return this.Agent_Rank;
        }
    }
}
