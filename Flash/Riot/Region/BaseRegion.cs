using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash.Riot.Region
{
    public abstract class BaseRegion
    {
        public abstract string Name {get;}
        public abstract string Server { get; }
        public abstract string LoginQueue { get; }
        public abstract string Code { get; }
        public abstract string Purchase { get; }

        public static BaseRegion Get(string region)
        {
            var regions = new Dictionary<string, Type>()
            {
                {"NA", typeof(NA)},
                {"EU", typeof(EU)},
                {"EUNE", typeof(EUNE)},
                {"BR", typeof(BR)},
                {"RU", typeof(RU)},
                {"TR", typeof(TR)}
            };

            if (regions.ContainsKey(region.ToUpper()))
                return Activator.CreateInstance(regions[region.ToUpper()]) as BaseRegion;

            return null;
        }
    }
}
