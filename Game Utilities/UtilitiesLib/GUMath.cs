using System;
using System.Collections.Generic;
using System.Text;

namespace UtilitiesLib
{
    static public class UMath
    {
        static public float CalcDPS(float dmg, float fireRate, float critChance = 0, float critMultiplier = 0)
        {
            float nonCritDps = dmg * (fireRate * (1 - critChance));
            float critDps = (dmg * critMultiplier) * (fireRate * critChance);

            return nonCritDps + critDps;
        }
    }
}
