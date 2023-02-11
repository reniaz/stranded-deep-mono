using Beam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine;

namespace DeepSeaNig
{
    class ESP : MonoBehaviour
    {
        Player player = FindObjectOfType<Player>();

        public static string getEntName(string text)
        {
            text = text.Replace("Go", "").Replace("(Clone)", "").Replace("0", "").Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("lb_", "").Replace("_small", " Small").Replace("_medium", " Medium").Replace("_dummy", "").Replace("_base", "").Replace("_net", "");
            return new Regex("<[^>]+>").Replace(text, string.Empty);
        }

        public void stringESP(LandAnimal mutant)
        {
            Vector3 pivotPos = mutant.transform.position;
            Vector3 mutantPos; mutantPos.x = pivotPos.x; mutantPos.z = pivotPos.z; mutantPos.y = pivotPos.y;
            Vector3 w2s_footpos = Camera.main.WorldToScreenPoint(mutantPos);
            float distance = (float)Math.Round((double)Vector3.Distance(player.transform.position, mutant.transform.position), 1);


            if (w2s_footpos.z > 0f && distance < 250f)
            {
                Render.DrawString(new Vector2(w2s_footpos.x, (float)Screen.height - w2s_footpos.y), getEntName(mutant.name) + " [" + distance.ToString() + "m]", Color.yellow);
            }
        }
    }
}
