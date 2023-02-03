using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening
{
    public class SvømmeHold : Hold
    {
        public string SvømmeHal { get; set; }

        public SvømmeHold(string holdId, int år, string holdNavn, double prisPrDeltager, int maxAntalBørn, string svømmehal):base(holdId,år,holdNavn,prisPrDeltager,maxAntalBørn)
        {
            SvømmeHal = svømmehal;
        }

        public override string ToString()
        {
            return base.ToString() + $" Svømmehal {SvømmeHal}";
        }

    }
}
