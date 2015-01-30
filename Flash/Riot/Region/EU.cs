using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash.Riot.Region
{
    class EU : BaseRegion
    {
        public override string Name
        {
            get { return "EU"; }
        }

        public override string Server
        {
            get { return "prod.euw1.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://lq.euw1.lol.riotgames.com/"; }
        }

        public override string Code
        {
            get { return "euw"; }
        }

        public override string Purchase
        {
            get { return "https://store.euw1.lol.riotgames.com/store/purchase/item"; }
        }

    }
}
