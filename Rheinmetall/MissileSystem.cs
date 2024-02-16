using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheinmetall
{
    public class MissileSystem : Goods
    {

        public override double GetValue()
        {
            switch (Condition)
            {
                case Quality.low:
                    return (double)Quality.low + Manufactor;
                    break;
                case Quality.medium:
                    return (double)Quality.medium + Manufactor;
                    break;
                case Quality.high:
                    return (double)Quality.high + Manufactor;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
