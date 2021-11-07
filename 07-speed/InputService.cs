using System;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }


        public string GetLetter()
        {
            int keyInt = Raylib.GetCharPressed();

            string keyString = "";
            if(keyInt!= 0)
            {
                if((Raylib_cs.KeyboardKey)keyInt == Raylib_cs.KeyboardKey.KEY_ENTER)
                {
                    keyString = "\n";
                }
                else
                {
                    char keyChar = (char)keyInt;
                    keyString = keyChar.ToString().ToLower();
                }
            }
            return keyString;

        }
        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }

}