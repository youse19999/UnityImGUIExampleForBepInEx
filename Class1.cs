using BepInEx;
using UnityEngine;
using UnityEngine.UI;

namespace TheKoikatuDevHax
{
    [BepInPlugin("0123121", "Hax", "1.0.0")]
    public class Class1:BaseUnityPlugin
    {
        //HAHA NICE DEBUGGER
        //YOU CAN EDIT THIS CODES.
        //BUT IF YOU WANNA UPLOAD PLEASE ADD LINK GITHUB OR DOWNLOADLINK WITH THIS CODE.
        bool isopen = false;
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo("Hax is loaded ;)💩");
        }
        private void Update()
        {
            // Plugin startup logic
            if (Input.GetKeyDown(KeyCode.Insert)){
                if (isopen == true)
                {
                    Logger.LogInfo("Close");
                    isopen = false;
                }
                else
                {
                    Logger.LogInfo("Open");
                    isopen = true;
                }
            }
        }
        
        private void OnGUI()
        {
            if (isopen == true)
            {
                GUI.Box(new Rect(10, 10, 100, 90), "Loader Menu");
            }
            else
            {

            }
        }
    }
}