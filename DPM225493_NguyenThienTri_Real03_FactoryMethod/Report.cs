using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern03_FactoryMethodReal
{
    internal class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new BibliographyPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new ResultsPage());
        }
    }
}
