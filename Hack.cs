using Beam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DeepSeaNig
{
    class Hack : MonoBehaviour
    {
        Statistics stats = new Statistics();
        public void GodMode()
        {
            stats.AddHealth(1000f);
            stats.AddOxygen(1000f);
        }
    }
}
