using Beam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace DeepSeaNig
{
    class Utilities : MonoBehaviour
    {
        Color redColor = new Color(255f / 255f, 130f / 255f, 130f / 255f);
        Color blueColor = new Color(130f / 255f, 130f / 255f, 255f / 255f);
        Color guiColor = Color.white;
        private bool bMenu = false;
        private bool bEsp = false;
        private bool bGod = false;
        ESP esp = new ESP();
        Hack hacks = new Hack();

        public void Start()
        {

        }

        public void Update()
        {
            guiColor = Color.Lerp(redColor, blueColor, Mathf.PingPong(Time.time, 1));
            if (UnityEngine.Input.GetKeyDown(KeyCode.Insert))
            {
                bMenu = !bMenu;
            }

            if (UnityEngine.Input.GetKeyDown(KeyCode.Delete))
            {
                Loader.Unload();
            }

            if (bGod) { hacks.GodMode(); }
        }

        public void OnGUI()
        {
            GUI.color = guiColor;
            GUI.Label(new Rect(10, 10, 150, 30), "zain#7777 | DeepSeaNig");
            if (bMenu)
            {
                bEsp = GUI.Toggle(new Rect(10, 30, 150, 20), bEsp, "ESP");
                bGod = GUI.Toggle(new Rect(10, 45, 150, 20), bGod, "GOD");
            }

            if (bEsp)
            {
                foreach (LandAnimal t in UnityEngine.Object.FindObjectsOfType<LandAnimal>() as LandAnimal[]) { esp.stringESP(t); }
                return;
            }
        }
    }
}
