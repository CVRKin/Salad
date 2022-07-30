using System;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: MelonInfo(typeof(salad.MyMod), "salad", "0.0.1a", "Kin")]
[assembly: MelonGame("Alpha Blend Interactive", "ChilloutVR")]

namespace salad
{
    public class MyMod : MelonMod
    {
        public override void OnApplicationStart()
        {
            [DllImport("user32.dll", EntryPoint = "SetWindowText")]
            static extern bool SetWindowText(System.IntPtr hwnd, System.String lpString);
            [DllImport("user32.dll", EntryPoint = "FindWindow")]
            static extern System.IntPtr FindWindow(System.String className, System.String windowName);
            System.IntPtr windowPtr = FindWindow(null, "ChilloutVR");
            SetWindowText(windowPtr, "ChilloutVR - salad");
            Logger.Log("Get salad'd");
        }
    }
}
