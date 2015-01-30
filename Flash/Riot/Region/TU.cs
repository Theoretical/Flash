using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash.Riot.Region
{
    class TR : BaseRegion
    {
        public override string Name
        {
            get { return "tr"; }
        }

        public override string Server
        {
            get { return "prod.tr.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://lq.tr.lol.riotgames.com/"; }
        }

        public override string Code
        {
            get { return "tr"; }
        }

        public override string Purchase
        {
            get { return "https://store.tr.lol.riotgames.com/store/purchase/item"; }
        }

    }
}
