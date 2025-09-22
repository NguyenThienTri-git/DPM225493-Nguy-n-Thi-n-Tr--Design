using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern03_FactoryMethodReal
{
    internal class Resume : Document
    {
        public override void CreatePages()
        {
            
            Pages.Add(new ExperiencePage());
            Pages.Add(new EducationPage());
            Pages.Add(new SkillsPage());
            
        }
    }
}
