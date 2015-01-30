using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash.Riot.Region
{
    class RU : BaseRegion
    {
        public override string Name
        {
            get { return "RU"; }
        }

        public override string Server
        {
            get { return "prod.ru.lol.riotgames.com"; }
        }

        public override string LoginQueue
        {
            get { return "https://lq.ru.lol.riotgames.com/"; }
        }

        public override string Code
        {
            get { return "ru"; }
        }

        public override string Purchase
        {
            get { return "https://store.ru.lol.riotgames.com/store/purchase/item"; }
        }

    }
}
