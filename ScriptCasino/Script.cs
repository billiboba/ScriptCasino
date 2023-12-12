using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCasino
{
    public class Script
    {
        public static Dictionary<string,int> GetSkins()//На вход получение скинов
        {
            var skins = new Dictionary<string, int>()
            {
                { "usp", 100},
                {"awp", 400},
                { "ak", 1100},
                {"deagle", 200 },
                {"ssg",30 },
            };
            return skins;
        }
        public static void LogicScript(int priceCase, Dictionary<string, int> skins)
        {
            float[] chances = new float[skins.Count];
            float totalChance = 0;
            priceCase = 300;
            int i = 0;
            foreach (var sk in skins)
            {
                if (sk.Value < priceCase)
                {
                    chances[i] = (((float)sk.Value / priceCase) * 100);
                }
                else
                {
                    chances[i] = (((float)sk.Value / priceCase) * 100) - 100;
                }
                totalChance += chances[i];
                i++;
            }
            for (int j = 0; j < skins.Count; j++)
            {
                chances[j] = (chances[j] / totalChance) * 100;
                Console.WriteLine(chances[j]);
            }
        }
    }
}
