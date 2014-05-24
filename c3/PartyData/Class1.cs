using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyData
{

    public class PartyData
    {
        public DrinkType drinkType { get; set; }
        public List<SnackData> Snacks { get; set; }
    }

    public class SnackData
    {
        public bool Salo { get; set; }
        public bool? Caviar { get; set; }
        public bool Jam { get; set; }
        public int Толщина { get; set; }

        public override string ToString()
        {
            var s = "Бутерброд толщиной " + Толщина + "мм ";
            if (Salo)
                s += " с салом";
            if (Caviar.HasValue && Caviar.Value)
                s += " с икрой";
            if (Jam)
                s += " с вареньем";
            return s;
        }
    }

    public enum DrinkType
    {
        Tea,
        Coffee
    }
}
