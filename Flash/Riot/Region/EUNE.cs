using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash.Riot.Region
{
    class EUNE : BaseRegion
    {
        public override string Name
        {
            get { return "EUNE"; }
        }

        public override string Server
        {
            get { return "prod.eun1.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://lq.eun1.lol.riotgames.com/"; }
        }

        public override string Code
        {
            get { return "eune"; }
        }

        public override string Purchase
        {
            get { return "https://store.eun1.lol.riotgames.com/store/purchase/item"; }
        }
    }
}
