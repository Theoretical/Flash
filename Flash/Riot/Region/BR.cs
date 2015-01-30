using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash.Riot.Region
{
    class BR : BaseRegion
    {
        public override string Name
        {
            get { return "BR"; }
        }

        public override string Server
        {
            get { return "prod.br.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://lq.br.lol.riotgames.com/"; }
        }

        public override string Code
        {
            get { return "br"; }
        }

        public override string Purchase
        {
            get { return "https://store.br.lol.riotgames.com/store/purchase/item"; }
        }

    }
}
