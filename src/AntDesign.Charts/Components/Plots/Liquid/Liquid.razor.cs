using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AntDesign.Charts
{
    public partial class Liquid<TItem> : ChartComponentBase<IEnumerable<TItem>, LiquidConfig>
    {
        public Liquid() : base("Liquid")
        {

        }
    }
}


