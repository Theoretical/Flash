using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash.Riot.Region
{
    class NA : BaseRegion
    {
        public override string Name
        {
            get { return "NA"; }
        }

        public override string Server
        {
            get { return "prod.na2.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://lq.na2.lol.riotgames.com/"; }
        }

        public override string Code
        {
            get { return "na"; }
        }

        public override string Purchase
        {
            get { return "https://store.na2.lol.riotgames.com/store/purchase/item"; }
        }
    }
}
