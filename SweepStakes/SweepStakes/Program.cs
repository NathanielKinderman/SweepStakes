using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ISweepstakesManager manager = SweepstakesFactory.ChooseYourSweepstakesManagerStyle();
            MarketingFirm marketingFirm = new MarketingFirm(manager);
            marketingFirm.CreateSweepstakes();

 
        }
    }
}
